 ![img](https://i.imgur.com/XvUmyGB.png)
 The **AudUnity** project is used to make audio playing and sound management in **Unity** easier than ever.
 To use it, add an Audio Player component, drag an audio library to it and play the sounds by calling the play method on the Audio Player.

### Content
- [**Setup Examples**](#setup-examples)
- [**Documentations**](#documentations)
  - [Local & Global Audio Player](#local-and-global-audio-player)
  - [Cooldown](#cooldown)

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
### Local and Global Audio Player  
Properties and Methods the global and local Audio Players have in common
- Properties
  - **SoundCount**  
  A property that returns the amount of initialized sounds in the audio player  
    
- Methods
  - **Play (string soundName)**  
  Plays a sound from the audio player by its name.
  
  - **PlayDelayed (string soundName, float delay)**  
  Like "Play", but it will play the sound with a delay specified in seconds
  
  - **AddSounds (AudioLibrary[])**  
   **AddSounds (AudioLibrary)**  
   **AddSounds (Sound[])**  
   A method for adding many sounds (initializing them) manually when the game/application runs.
  
  - **AddSound (Sound)**  
   **AddSound (SoundData)**  
   A method for adding (initializing) a single sound manually when the game/application runs.  

  - **RemoveSound (string soundName)**  
  A method for removing a sound from the audio player while the game/application is running.  
  
  - **TryRemoveSound (string soundName)**  
  Same as "RemoveSound" but it'll check if the sound exists in the player and only if it does, it'll call the remove method.
