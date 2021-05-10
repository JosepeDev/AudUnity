using UnityEngine;

namespace Sounder
{
    /// <summary>
    /// A scriptable object that stores a sound
    /// </summary>
    [CreateAssetMenu(fileName = "Sound", menuName = LocalAudioPlayer.menuCategory + "Sound", order = 0)]
    public class Sound : ScriptableObject
    {
        /// <summary>
        /// The sound contained in the preset
        /// </summary>
        [Tooltip("The sound contained in the preset")]
        public SoundData sound;
        
        /// <summary>
        /// Set the name of the sound by the name of the scriptable objcet
        /// </summary>
        protected internal void NameByObject() => sound.soundName = name;

        /// <summary>
        /// Set the name of the sound by the name of the audio clip
        /// </summary>
        protected internal void NameByClip() => sound.soundName = sound.clip.name;

        public Sound()
        {
            sound = new SoundData("Unamed sound");
        }
    }
}
