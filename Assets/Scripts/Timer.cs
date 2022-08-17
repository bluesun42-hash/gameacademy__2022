using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeValue ;
    public int seconds;
    public int minutes;
    public Text timeText;
    static public string winner;
    public GlobalCellManager GlobalCellManagerScript;
   

    private void Start()
    {
        
        timeValue = 90;
    }
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
        if (timeValue <= 0)
        {
            SceneManager.LoadScene("finalScene");
            if(GlobalCellManagerScript.percentageOfFull >= 0.5f)
            {
                winner = "joueur 1";
            }else
            {
                winner = "joueur 2";
            }
        }
    }
    

}
