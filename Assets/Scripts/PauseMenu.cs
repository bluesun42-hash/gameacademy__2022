using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Music;
    public GameObject obj;
    bool state;
    AudioSource[] AudioSource;
    AudioSource MainTheme;
    AudioSource ZickZack;

    float PartPas;

    void Start() 
    {
        AudioSource = Music.GetComponents<AudioSource>();
        MainTheme = AudioSource[0];
        ZickZack = AudioSource[1];

        Debug.Log(AudioSource);
    }

    public void OpenCloseUi()
    {
        state = obj.activeSelf;
        state = !state;
        if (state)
        {
            PartPas = ZickZack.volume - 0.5f;
            MainTheme.volume -= 0.5f;
            ZickZack.volume -= 0.5f;
        } else
        {
            MainTheme.volume += 0.5f;
            ZickZack.volume += 0.5f + PartPas;
        }
        obj.SetActive(state);
    }
}
