using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnfantDoublage : MonoBehaviour
{
    public Sound[] sounds;
    Sound s;

    System.Random rng = new System.Random();

    private void Start()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = 1;
            s.source.pitch = 1;
            s.source.loop = false;
        }
    }

    private void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    public void KidSound()
    {
        Play(rng.Next(1,7).ToString());
    }
}
