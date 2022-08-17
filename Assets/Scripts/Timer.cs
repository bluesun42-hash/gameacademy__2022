using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public int seconds;
    public int minutes;
    public Text timeText;

    private void FixedUpdate()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.fixedDeltaTime;
        }
        else
        {
            timeValue = 0;
        }
       
        minutes = Mathf.FloorToInt(timeValue)/60;
        Debug.Log(minutes);
        seconds = Mathf.FloorToInt(timeValue - 60 * minutes);
        Debug.Log(seconds);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
