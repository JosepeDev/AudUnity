using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    [Tooltip("Pick a name for your sound.")]
    public string soundName;

    [Tooltip("The audio clip of the sound.")]
    public AudioClip clip;

    [Tooltip("The volume of the sound.")]
    [Range(0f, 1f)]
    public float volume = 1f;

    [Tooltip("Turn on if you want the sound to loop after it has been played.")]
    public bool looping = false;

    [Tooltip("Turn on if you want the sound to be played automatically when Awake is being called.")]
    public bool playOnAwake = false;

    [Tooltip("Choose the mixer in which the sound will be played.")]
    public AudioMixerGroup mixer;

    public bool IsUninitialized
    {
        get
        {
            return
                (
                    volume != 1 ||
                    (
                        string.IsNullOrEmpty(soundName) &&
                        volume == 0f &&
                        clip == null
                    )
                );
        }
    }

    public Sound()
    {
        volume = 1f;
    }
}