using UnityEditor;
using UnityEngine;

namespace Sounder
{
    [CustomEditor(typeof(GlobalAudioPlayer))]
    public class GlobalAudioPlayerEditor : Editor
    {
        readonly string btxt_init = "Initialize";

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GlobalAudioPlayer player = (GlobalAudioPlayer)target;

            if (!player.initializeOnAwake)
            {
                if (GUILayout.Button(btxt_init))
                {
                    player.Initialize();
                }
            }

            if (player.cashedInitializeOnAwake != player.initializeOnAwake)
            {
                player.ResetAudioSourcesContainer();
                player.cashedInitializeOnAwake = player.initializeOnAwake;
            }
        }
    }
}
