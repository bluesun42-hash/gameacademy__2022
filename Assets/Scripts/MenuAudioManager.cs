using UnityEngine.Audio;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MenuAudioManager : MonoBehaviour
{
    public Text text;
    public Sound[] sounds;
    public Slider MenuSlider;
    AudioSource audioSource;
    public GameObject GameObject;

    string purcent;

    void Awake()
    {
        

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = 1;
            s.source.loop = true;
        }
    }

    public void SlidUpDate()
    {
        audioSource = GameObject.GetComponent<AudioSource>();
        PublicVar.MusicVol = MenuSlider.value/100;
        audioSource.volume = PublicVar.MusicVol;
        purcent = MenuSlider.value + "%";

        try { text.text = purcent; } catch { }

        
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    void Start()
    {
        Play("MenuTheme");
        Debug.Log(AudioListener.volume);
        MenuSlider.value = PublicVar.MusicVol * 100;
    }
}
