using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(menuName = "SoundPreset")]
public class SoundPreset : ScriptableObject
{
    [Tooltip("The sound contained in the preset.")]
    public Sound sound;
}