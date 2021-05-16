 ![img](https://i.imgur.com/XvUmyGB.png)
 The **AudUnity** project is used to make audio playing and sound management in **Unity** easier than ever.
 To use it, add an Audio Player component, drag an audio library to it and play the sounds by calling the play method on the Audio Player.

### Content
- [**Setup Examples**](#setup-examples)
- [**Documentations**](#documentations)
  - [Audio Players](#audio-players)
  - [Audio Library](#audio-library)
  - [Sound](#sound)

# How it works
 - **Local Audio Player** component  
  Used on objects like enemies in your game, or just sound you want to **play** on a **specific location** in your game world.  
  
 - **Global Audio Player** component  
  Will be used for stuff like, UI sounds, and sounds you just want to **play globally in your scene**.
  
 - **Global Audio Player Link** component  
  For calling the Global Audio Player inside the unity editor (Button component etc...)
  
 - **Audio Library** scriptable object  
  An object that contain sounds, and can reference other audio libraries.  
  You can make many audio libraries divided by category or a theme, and refernce them in a single audio library.  
  
 - **Sound** scriptable object  
  An object that contains all the data about your sound.  
  Its volume, name, audio mixer, whether the sound should loop when it's played and much more.  
   
 An **Audio Player**, takes an **Audio Library** object, and initializes the sound it contains so you'll be able to play them easily.
 The **Local Audio Player** is 
 The **Global Audio Player**, will be used for stuff like, UI sounds, and sounds you just want to **play globally in your scene**.
 Only a **single** Global Audio Player **component can exist in a scene**, and it is recomended to **put it on the camera** along with the Audio Listener.
 Then create a new Audio Library object, add Sound objects to it and drag it to the Audio Player.
 
# Usage Examples
 If you have already initialized an Audio Player, this is how you can use it:  
 Let's say you wanna play the shooting sound of your gun.  
 First thing you got to do is to reference the Audio Player you want to call.  
   
 ```csharp
 public LocalAudioPlayer audioPlayer; // in insperctor
 ```
   
 You can play the shooting sound by calling the "Play" method, using the name you gave to the sound in its sound object.
 
 ```csharp
 void Shoot()
 {
   audioPlayer.Play("shoot-sound");
 }
 ```
 
 You can also play the sound with a delay specified in seconds.
 
 ```csharp
 audioPlayer.PlayDelayed("shoot-sound", 2.3f);
 ```

# Setup Examples
### User Interface
 Let's say you have a button in Unity, and you have a sound you want the button to play when it is being pressed.  
 For audio like that, you wanna use the Global Audio Player, because you want UI sounds to play globally on the scene.  
 So go to your main camera in your scene and click **Add Component/AudUnity/Global Audio Player**.  
   
 ![img](https://i.imgur.com/G3UTAca.png)  ![img](https://i.imgur.com/Ogj5QOd.png)  
   
 Now after you added a Global Audio Player, all you got to add Audio Libraries to it.  
 To do that, right click inside Unity's Project window, choose **Create/Sounder/AudioLibrary**, and name it UI.  
   
 ![img](https://i.imgur.com/PV98Yjo.png)
   
 Now you have an Audio Library named UI that you can reference inside AudioPlayers.  
 So do it, and drag that Audio Library to the list in the Audio Player component.
 
 ![img](https://i.imgur.com/8VaCTsr.png)  ![img](https://i.imgur.com/0k8ZFcb.png)
 
 Inside Unity's Project window, press **right click**, and choose **Create/Sounder/Sound** and create a new sound.  
   
 ![img](https://i.imgur.com/ryZihQU.png)  
   
 That's a sound object, and it consists of many value you can change to set every type of sound in your game.  
 You can change the volume, the name, the mixer, you can make the sound loop and much more.  
   
 ![img](https://i.imgur.com/t1UUQgv.png)  
 
 Then, create a new Audio Library. You can do it by pressing right click inside Unity's Project window an choosing **Create/Sounder/AudioLibrary** An audio lbrary is just an object that has an array of sounds in it.  
 For example, if you created a sound for the for your UI, that you want to play when the player pushes a button, you w
 
# Documentations
- [Audio Players](#audio-players)
- [Audio Library](#audio-library)
- [Sound](#sound)

## Audio Players  
The two main Unity MonoBehaviour components that play the audio.  

A **Local Audio Player** component will be used on objects like enemies in your game, or just sound you want to play on a specific location in your game world.  

A **Global Audio Player** component will be used for stuff like, UI sounds, and sounds you just want to play globally in your scene. Only a single Global Audio Player component can exist in a scene, and it is recomended to put it on the camera along with the Audio Listener.  

For using in the code a **Local Audio Player** you **need a reference** of the Audio Player, **but** for the **Global Audio Player** you you **don't need a reference** and can **call** the methods and the properties **instantly** through the **static members** of the Global Audio Player class.

- Variables
  - **Linked Audio Libraries**  
  The Audio Libraries the Audio Player Initializes
  
  - **Initialize On Awake**  
  A toggle box, visible in the inspector, determines if the Audio Player should be initialized on awake.  
  If set to false, make sure you press the Initialize button on the Audio Player every time you change somthing about the Linked Audio Libraries.  

- Properties
  - **SoundCount**  
  A property that returns the amount of initialized sounds in the audio player  
    
- Methods
  - **Play (string)**  
  Plays a sound from the audio player by its name.
  
  - **PlayDelayed (string, float)**  
  Like "Play", but it will play the sound with a delay specified in seconds
  
  - **Stop (string)**  
  Stops a sound from the audio player by its name.  
  
  - **Pause (string)**  
  Pauses a sound from the audio player by its name.
  
  - **UnPause (string)**  
  Un pauses a sound from the audio player by its name.
  
  - **SetVolume (string, float)**  
  Sets a sound's volume from the audio player by its name.
  
  - **SetMute (string, bool)**  
  Mutes or unmutes a sound from the audio player by its name.
  
  - **SetLoop (string)**  
  Plays a sound from the audio player by its name.
  
  - **IsPlaying (string)**  
  Returns true if the sound is currently playing and false if it's not

  - **SoundExist (string)**  
  Check if a sound exists in the audio player

  - **GetSoundAudioSource (string)**  
  Returns the Audio Source component for the sound.  
  If you don't want to play it through the audio player.

  - **AddSounds (AudioLibrary[])**  
   **AddSounds (AudioLibrary)**  
   **AddSounds (Sound[])**  
   A method for adding many sounds (initializing them) manually when the game/application runs.
  
  - **AddSound (Sound)**  
   **AddSound (SoundData)**  
   A method for adding (initializing) a single sound manually when the game/application runs.  

  - **RemoveSound (string)**  
  A method for removing a sound from the audio player while the game/application is running.  
  
  - **TryRemoveSound (string)**  
  Same as "RemoveSound" but it'll check if the sound exists in the player and only if it does, it'll call the remove method.

## Global Audio Player
Works exactly like a Local Audio Player, but if you want to call its methods or properties, you can do it without a reference, because only a single Global Audio Player can exist in a scene.
**Local Audio Player Example Code**  
Playing a shooting sound when the method Shoot() is called 

```cs
// the name you gave to the sound inside the scriptable object
string soundName_shoot = "shoot";
LocalAudioPlayer audioPlayer;

private void Awake() 
{
    // gets the Local Audio Player component from the game object
    audioPlayer = GetComponent<LocalAudioPlayer>();
}

private void Update() 
{
    // if the player clicks the mouse button, shoot
    if (Input.GetKeyDown(KeyCode.Mouse0))
    {
        Shoot();
    }
}

void Shoot()
{
    // some shooting behaviour
    audioPlayer.Play(soundName_shoot); // play shoot sound
}
```

**Global Audio Player Example Code**  
Playing a shooting sound when the method Shoot() is called
```cs
// the name you gave to the sound inside the scriptable object
string soundName_shoot = "shoot";

private void Update() 
{
    // if the player clicks the mouse button, shoot
    if (Input.GetKeyDown(KeyCode.Mouse0))
    {
        Shoot();
    }
}

void Shoot()
{
    // some shooting behaviour
    // no need to get the audio player instance
    GlobalAudioPlayer.Play(soundName_shoot); // play shoot sound
}
```

## Audio Library
Used for storing many sounds.  
A **scriptable object** that **contains sounds** and can also **reference other audio libraries**.  
So if you initialize an **AudioLibrary**, it will initialize every sound it contains, and then, it will also initialize **all the libraries** referenced in that audio library too.  
A library can be initialized if it is **referenced inside** an **Audio Player**.  
To reference a library in a player, **add it** to the array of libraries **Linked Audio Libraries** inside an AudioPlayer.

- Variables
  - **Sounds**  
  The sounds contained in the audio library.


  - **Audio Libraries**  
  An Audio Library can reference other Audio libraries.  
  So you can create many small libraries and link them together inside a mega library that references them.

## Sound
Used for storing a data about a sound.  
When a sound is initialized, it takes all the data from the Sound object, and initializes the sound with that data.  
Only change variables that you know what they're doing.  
To play the sound, put it inside a [library](#audio-library), and initialize the library inside an [AudioPlayer](#audio-players) and call the Play method.

- Variables
  - **soundName**  
  The name of the sound.  
  It will be used to call it from the audio player.  
  You can also press the button **Name by Scriptable Object name** to quickly name the sound by its scriptable object name, or the **Name by Audio Clip name** button, to quickly name the sound by the name of its audio clip.

  - **clip**  
  The sound's audio clip.  
  The actual audio the sound will play.

  - **mixer**  
  If you want the sound to be played through a specific mixer  
    

  - **priority**  
  Sets the priority of the sound's AudioSource when it is initialized.  

  - **volume**  
  The volume of the sound's audio source (0.0 to 1.0).

  - **pitch**  
  The pitch of the sound's audio source.  

  - **stereoPan**  
  Pans the sound in a stereo way (left or right).  
  This only applies to sounds that are Mono or Stereo.  

  - **spatialBlend**  
  Sets how much the sound's AudioSource is affected by 3D spatialisation calculations (attenuation, doppler etc).  
  0.0 makes the sound full 2D, 1.0 makes it full 3D.

  - **reverbZoneMix**  
  The amount by which the signal from the sound's AudioSource will be mixed into the global reverb associated with the Reverb Zones.

  - **mute**  
  Whether the sound sould be muted upon initialization.  
  Mute sets the volume=0, Un-Mute restore the original volume.  

  - **bypassEffects**  
  Bypass effects (Applied from filter components or global listener filters).

  - **bypassListenerEffects**  
  When set to true, global effects on the AudioListener will not be applied to the audio signal generated by the sound's AudioSource.  
  Does not apply if the sound's AudioSource is playing into a mixer group.


  - **bypassReverbZones**  
  When set to true, doesn't route the signal from sound into the global reverb associated with reverb zones. 

  - **playOnAwake**  
  If set to true, the audio source will automatically start playing on awake.

  - **loop**  
  Determines if the sound should loop when it is played
  