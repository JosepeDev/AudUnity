using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] SoundLibrary soundLibrary;

    Sound[] _sounds
    {
        get { return soundLibrary.sounds; }
    }

    SoundPreset[] _soundPresets
    {
        get { return soundLibrary.soundPresets; }
    }

    SoundLibrary[] _soundLibraries
    {
        get { return soundLibrary.soundLibraries; }
    }

    public Dictionary<string, AudioSource> audioSources = new Dictionary<string, AudioSource>();

    private void Awake()
    {
        Initialize();
    }

    private void Initialize() => AddSounds(soundLibrary);

    public void AddSounds(List<SoundLibrary> libraries) => AddSounds(libraries.ToArray());

    public void AddSounds(List<SoundPreset> soundPresets) => AddSounds(soundPresets.ToArray());

    public void AddSounds(List<Sound> sounds) => AddSounds(sounds.ToArray());

    public void AddSounds(SoundLibrary[] libraries)
    {
        if (libraries != null && libraries.Length >= 1)
        {
            for (int i = 0; i < libraries.Length; i++)
            {
                AddSounds(libraries[i]);
            }
        }
    }

    public void AddSounds(SoundLibrary library)
    {
        if (library != null)
        {
            AddSounds(library.sounds);
            AddSounds(library.soundPresets);
            AddSounds(library.soundLibraries);
        }
    }

    public void AddSounds(Sound[] sounds)
    {
        if (sounds != null && sounds.Length >= 1)
        {
            // create an audio source component for each sound and set its settings
            for (int i = 0; i < sounds.Length; i++)
            {
                AddSound(sounds[i]);
            }
        }
    }

    public void AddSounds(SoundPreset[] soundPresets)
    {
        if (soundPresets != null && soundPresets.Length >= 1)
        {
            // create an audio source component for each sound preset and set its settings
            for (int i = 0; i < soundPresets.Length; i++)
            {
                AddSound(soundPresets[i]);
            }
        }
    }

    public void AddSound(Sound s)
    {
        var source = gameObject.AddComponent<AudioSource>();

        // apply propeties
        source.clip = s.clip;
        source.volume = s.volume;
        source.loop = s.looping;
        source.outputAudioMixerGroup = s.mixer;

        if (s.playOnAwake)
        {
            source.Play();
        }

        // add to audio sources list
        audioSources.Add(s.soundName, source);
    }

    public void AddSound(SoundPreset s) => AddSound(s.sound);

    public void RemoveSound(string name)
    {
        AudioSource source = audioSources[name];
        source.Stop();
        audioSources.Remove(name);
        Destroy(source);
    }

    public void RemoveSound(Sound s) => RemoveSound(s.soundName);

    public void RemoveSound(SoundPreset s) => RemoveSound(s.sound.soundName);

    public void SoundPlay(string soundName) => audioSources[soundName].Play();

    public void SoundStop(string soundName) => audioSources[soundName].Stop();

    public void SoundSetVolume(string name, float volume)
    {
        if (volume > 1f) volume = 1f;
        if (!string.IsNullOrWhiteSpace(name))
        {
            audioSources[name].volume = volume;
        }
    }

    public void SoundSetVolumePercentage(string name, float percentage) => SoundSetVolume(name, percentage / 100);

    public Sound GetSound(string soundName)
    {
        for (int i = 0; i < _sounds.Length; i++)
        {
            if (_sounds[i].soundName == soundName) return _sounds[i];
        }

        for (int i = 0; i < _soundPresets.Length; i++)
        {
            if (_soundPresets[i].sound.soundName == soundName) return _soundPresets[i].sound;
        }

        for (int i = 0; i < _soundLibraries.Length; i++)
        {
            var sound = _soundLibraries[i].GetSound(soundName);
            if (sound != null) return sound;
        }

        return null;
    }
}
