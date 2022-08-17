using UnityEngine.Audio;
using System.Collections;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    private float volumeIncrease = 0f;
    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = 1;
        }
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    
    public void IncreaseAndPlay(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.volume = volumeIncrease;
        s.source.Play();

        //Musique passe de 0 a 1 en 3min.
        StartCoroutine(WaitAndIncreaseVolume(s, 1.8f));
    }


    private IEnumerator WaitAndIncreaseVolume(Sound s,float waitTime)
    {
        for (int i = 0; i < 10; i++)
        {
            s.source.volume += 0.01f;
            yield return new WaitForSeconds(waitTime);
        }

    }


    void Start()
    {
        Play("MainTheme");
        IncreaseAndPlay("ZickZack");
    }
}