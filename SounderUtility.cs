using UnityEngine;

namespace Sounder
{
    public static class SounderUtility
    {
        static public void LogError(object msg) => Debug.LogError(msg);
        static public void LogErrorFormat(string format, params object[] args) => Debug.LogErrorFormat(format, args);
        static public void LogWarning(object msg) => Debug.LogWarning(msg);
        static public void LogWarningFormat(string format, params object[] args) => Debug.LogWarningFormat(format, args);
        static public void Log(object msg) => Debug.Log(msg);
        static public void LogFormat(string format, params object[] args) => Debug.LogFormat(format, args);

        static public void LogErrorSoundNull(int index, string libraryName) =>
            LogErrorFormat("The sound at index \"{0} \", in the audio library \"{1}\" is null", index, libraryName);

        static public void LogErrorSoundAlreadyExists(Sound s) => 
            LogErrorFormat("Could not add a Sound named: <{0}> because there is already a sound in this audio player with that name", s.sound.soundName);
    }
}
