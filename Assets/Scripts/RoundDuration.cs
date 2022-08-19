using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundDuration : MonoBehaviour
{
    public Slider slider;
    public Text text;

    // 300s max 90s min

    private void Start()
    {
        Debug.Log("time "+PublicVar.GameDuration);
        slider.value = (PublicVar.GameDuration-60)/30;
        PublicVar.GameDuration = slider.value * 30 + 60;
    }

    public void SliderUpDate()
    {
        PublicVar.GameDuration = slider.value * 30 + 60;
        Debug.Log((slider.value+2)%2);
        text.text = Mathf.Floor((slider.value * 30 + 60) / 60) + ":" + ((slider.value+2)%2 * 30)/10 + "0";
    }
}
