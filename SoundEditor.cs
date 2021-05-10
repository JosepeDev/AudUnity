using UnityEditor;
using UnityEngine;

namespace Sounder
{
    [CustomEditor(typeof(Sound))]
    public class SoundEditor : Editor
    {
        readonly string btxt_autoNameObject = "Name by Scriptable Object name";
        readonly string btxt_autoNameClip = "Name by Audio Clip name";

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            Sound sound = (Sound)target;

            GUILayout.Space(30);

            if (GUILayout.Button(btxt_autoNameObject))
            {
                sound.NameByObject();
            }

            if (sound.sound.clip != null)
            {
                if (GUILayout.Button(btxt_autoNameClip))
                {
                    sound.NameByClip();
                }
            }
        }
    }
}
