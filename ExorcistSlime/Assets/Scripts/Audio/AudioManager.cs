using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    public string currentSong;

    public AudioMixerGroup mixerGroup;

    // Start is called before the first frame update
    void Awake()
    {

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

        

        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
            sound.source.outputAudioMixerGroup = mixerGroup;
        }
    }

    public void StopAudio(string audioName)
    {
        Sound soundToStop = Array.Find(sounds, iteratorSound => iteratorSound.name == audioName);
        if (soundToStop == null)
        {
            Debug.Log("No se encontró el sonido");
            return;
        }
        //soundToStop.source.Stop();
    }

    public void PlayAudio (string audioName)
    {
        Sound soundToPlay = Array.Find(sounds, iteratorSound => iteratorSound.name == audioName);

        if (soundToPlay == null)
        {
            Debug.Log("No se encontró el sonido");
            return;
        }

        //if (currentSong != null)
        //{
        //    Debug.Log("Play audio " + audioName + " Current song " + currentSong);
        //    StopAudio(currentSong);
        //}

        //currentSong = audioName;


        //Debug.Log("A reproducir " + soundToPlay.name);
        soundToPlay.source.Play();

    }


    //Play songs
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
}
