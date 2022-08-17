using UnityEngine.Audio;
using System.Collections;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MenuAudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public Slider MenuSlider;
    AudioSource audioSource;
    public GameObject GameObject;

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

    public void SlidUpDate()
    {
       audioSource = GameObject.GetComponent<AudioSource>();
        audioSource.volume = MenuSlider.value;
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    void Start()
    {
        Play("MenuTheme");
    }
}
