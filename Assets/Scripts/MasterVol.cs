using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MasterVol : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 1;
        slider.SetValueWithoutNotify(AudioListener.volume);
    }
    public void OnValueChanged()
    {
        AudioListener.volume = slider.value;
        Debug.Log(AudioListener.volume);
    }
}
