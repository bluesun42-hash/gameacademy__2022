using UnityEngine.Audio;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = 1;
            s.source.pitch = 1;
            s.source.loop = true;
        }
    }

    private float volumeIncrease = 0f;
    
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
        while(true)
        {
            s.source.volume += 0.01f;
            yield return new WaitForSeconds(waitTime);
        }

    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        try{
        
        s.source.Play();
        } catch
        {

        }
    }

    void Start()
    {
        Play("MenuTheme");
        Play("MainTheme");
        IncreaseAndPlay("ZickZack");
    }
}