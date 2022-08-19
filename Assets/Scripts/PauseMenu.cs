using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject Music;
    public GameObject obj;
    bool state = true;
    AudioSource[] AudioSource;
    AudioSource MainTheme;
    AudioSource ZickZack;
    public Slider slider2;
    public Text text;
    float EnterVol;

    bool it = true;
    bool slide;

    void Start() 
    {
        slider2.value = PublicVar.MusicVol*100;
        Debug.Log(AudioListener.volume);
        AudioSource = Music.GetComponents<AudioSource>();
        MainTheme = AudioSource[0];
        MainTheme.volume = PublicVar.MusicVol;
        ZickZack = AudioSource[1];
    }

    public void OpenCloseUi()
    {
        Debug.Log(PublicVar.slideBool);
        state = obj.activeSelf;
        state = !state;
        if (state)
        {
            EnterVol = AudioListener.volume;
            AudioListener.volume *= 0.7f;
            Time.timeScale = 0;
        } 
        else 
        {
            Time.timeScale = 1;
            if (PublicVar.slideBool) 
            {
                PublicVar.slideBool = !PublicVar.slideBool;
            } 
            else 
            { 
                AudioListener.volume *= (1/0.7f);
                if (it)
                {
                    it = false;
                    AudioListener.volume *= (1 / 0.7f);
                }
            }
        }
        obj.SetActive(state);
        Debug.Log(AudioListener.volume);
        if(AudioListener.volume > 1)
        {
            AudioListener.volume = 1;
        }
    }

    public void SliderChange()
    {
        PublicVar.slideBool = true;

        AudioSource = Music.GetComponents<AudioSource>();
        MainTheme = AudioSource[0];
        MainTheme.volume = PublicVar.MusicVol;
        ZickZack = AudioSource[1];

        PublicVar.MusicVol = slider2.value/100;
        MainTheme.volume = PublicVar.MusicVol;
        text.text = slider2.value+"%";
    }
}
