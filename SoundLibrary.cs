using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SoundLibrary")]
public class SoundLibrary : ScriptableObject
{
    [Tooltip("Create new sounds here.")]
    public
    Sound[] sounds;

    [Tooltip("Import existing sound presets here.")]
    public
    SoundPreset[] soundPresets;

    [Tooltip("Import sound libraries.")]
    public
    SoundLibrary[] soundLibraries;

    /// <summary>
    /// Returns a sound object by a name.
    /// Returns null if the sound does not exists.
    /// </summary>
    /// <param name="soundName">The name of the sound</param>
    /// <returns></returns>
    public Sound GetSound(string soundName)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].soundName == soundName) return sounds[i];
        }

        for (int i = 0; i < soundPresets.Length; i++)
        {
            if (soundPresets[i].sound.soundName == soundName) return soundPresets[i].sound;
        }

        for (int i = 0; i < soundLibraries.Length; i++)
        {
            var sound = soundLibraries[i].GetSound(soundName);
            if (sound != null) return sound;
        }
        return null;
    }

    private void OnValidate()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].IsUninitialized)
            {
                sounds[i].volume = 1f;
            }
        }
    }
}
