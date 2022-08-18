using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MasterVol : MonoBehaviour
{
    public Text text;
    public Slider slider;

    private void Start()
    {
       
        slider.value = PublicVar.MasterVol*100;
    }
    public void OnValueChanged()
    {
        PublicVar.MasterVol = slider.value/100;
        AudioListener.volume = PublicVar.MasterVol;
        PublicVar.slideBool = true;

        text.text = slider.value + "%";
    }
}
    