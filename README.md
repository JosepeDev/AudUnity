 ![img](https://i.imgur.com/XR2WezD.png)
 Easy, simple, and organized audio management tool for Unity

### Content
- [**Setup & Examples**](#setup-and-examples)
- [**Documentations**](#documentations)
  - [Local & Global Audio Player](#local-and-global-audio-player)
  - [Cooldown](#cooldown)

# How it works
 The **Sounder** project is used to make audio playing and sound management in **unity** easier than ever.  
 To use it, add an Audio Player component, drag an audio library to it and play the sounds by calling the play method on the Audio Player.
 
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
 
 Inside Unity's Project window, press **right click**, and choose **Create/Sounder/Sound** and create a new sound.  
   
 ![img](https://i.imgur.com/ryZihQU.png)  
   
 That's a sound object, and it consists of many value you can change to set every type of sound in your game.  
 You can change the volume, the name, the mixer, you can make the sound loop and much more.  
   
 ![img](https://i.imgur.com/t1UUQgv.png)  
 
 Then, create a new Audio Library. You can do it by pressing right click inside Unity's Project window an choosing **Create/Sounder/AudioLibrary** An audio lbrary is just an object that has an array of sounds in it.  
 For example, if you created a sound for the for your UI, that you want to play when the player pushes a button, you w
 
# Setup And Examples
 Th
 
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
