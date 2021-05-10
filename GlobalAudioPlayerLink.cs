using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sounder
{
    /// <summary>
    /// A class for calling the global audio player in the scene from the unity editor (buttons, etc...)
    /// If you want to call the global audio player from script, just call the static class GlobalAudioManager
    /// </summary>
    [AddComponentMenu(LocalAudioPlayer.menuCategory + "Global Audio Player Link")]
    public class GlobalAudioPlayerLink : MonoBehaviour
    {
        public void Play(string soundName) => GlobalAudioPlayer.Play(soundName);
        public void PlayDelayed(string soundName, float delay) => GlobalAudioPlayer.PlayDelayed(soundName, delay);
        public void Stop(string soundName) => GlobalAudioPlayer.Stop(soundName);
        public void Pause(string soundName) => GlobalAudioPlayer.Pause(soundName);
        public void UnPause(string soundName) => GlobalAudioPlayer.UnPause(soundName);
        public void SetVolume(string name, float volume) => GlobalAudioPlayer.SetVolume(name, volume);
        public void SetMute(string name, bool mute) => GlobalAudioPlayer.SetMute(name, mute);
        public void SetLoop(string name, bool loop) => GlobalAudioPlayer.SetLoop(name, loop);
    }
}
