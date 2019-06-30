using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Souds array, contains all the audio files of the game
    public Sound[] sounds;

    //Instance of the audio manager (static)
    public static AudioManager instance;

    //Name of the song that is currently playing
    private string currentSong = null;

    public AudioMixerGroup mixerGroup;

    //Method to get the instance of the audio manager
    public static AudioManager GetInstance()
    {
        if (instance == null)
        {
            instance = new AudioManager();
        }
        return instance;
    }


    // Start is called before the first frame update
    void Awake()
    {
        //Create the instance of the audio manager, and set the DontDestroyOnLoad to keep it on scene changes
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        //Initialize all the sounds of the array with an audio source component
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
        }
    }

    //Method to stop a sound of the array
    public void StopAudio(string audioName)
    {
        Sound soundToStop = Array.Find(sounds, iteratorSound => iteratorSound.name == audioName);
        if (soundToStop == null)
        {
            Debug.Log("Song to stop : " + audioName + "not found");
            return;
        }
        soundToStop.source.Stop();
    }

    //Method to play a sound of the array
    public void PlayAudio (string audioName)
    {
        Sound soundToPlay = Array.Find(sounds, iteratorSound => iteratorSound.name == audioName);

        //If the sound was not found
        if (soundToPlay == null)
        {
            Debug.Log("Sound " + audioName + "not found");
            return;
        }

        //If the song to play its diferent from the current playing song
        //Stop the current playing song, and start the new song
        if(currentSong != null && currentSong != audioName)
        {
            StopAudio(currentSong);
            soundToPlay.source.Play();
            currentSong = soundToPlay.name;
        }
        else
        {
            //Its the first song
            if(currentSong == null)
            {
                soundToPlay.source.Play();
                currentSong = soundToPlay.name;
            }
        }
    }

    public void PlaySound(string soundName)
    {
        Sound soundToPlay = Array.Find(sounds, iteratorSound => iteratorSound.name == soundName);

        //If the sound was not found
        if (soundToPlay == null)
        {
            Debug.Log("Sound " + soundName + "not found");
            return;
        }

        soundToPlay.source.Play();

    }


    //Methods to play songs
    public void PlayMainMenuSong()
    {
        PlayAudio("MainMenuSong");
    }

    public void PlayFirstLevelSong()
    {
        PlayAudio("FirstLevelSong");
    }

    public void PlaySecondLevelSong()
    {
        PlayAudio("SecondLevelSong");
    }

    public void PlayBossSong()
    {
        PlayAudio("FinalBossSong");
    }

    public void PlayVictorySong()
    {
        PlayAudio("VictorySong");
    }

    public void PlayGameOverSong()
    {
        PlayAudio("GameOverSong");
    }

    //Game sounds
    public void SlimeDamageSound()
    {
        PlaySound("SlimeDamage");
    }

    public void SlimeTauntSound()
    {
        PlaySound("SlimeTaunt");
    }

    public void BossDamageSound()
    {
        PlaySound("BossDamage");
    }

    public void SlimeDashSound()
    {
        PlaySound("SlimeDash");
    }

    public void DoorOpenSound()
    {
        PlaySound("DoorOpen");
    }

    public void EnemyDamageSound()
    {
        PlaySound("EnemyDamage");
    }

}
