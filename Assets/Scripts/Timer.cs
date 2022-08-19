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
    public bool isVisible;
    

  
    private void Start()
    {
        Debug.Log("2 " + PublicVar.GameDuration);
        timeValue = PublicVar.GameDuration;
        //timeValue = 20;
    }
    private void FixedUpdate()
    {
       
            StartCoroutine(blink());

        






        if (timeValue > 0)
        {
            timeValue -= Time.fixedDeltaTime;
        }
        else
        {
            timeValue = 0;
        }
       
        minutes = Mathf.FloorToInt(timeValue)/60;
        seconds = Mathf.FloorToInt(timeValue - 60 * minutes);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (timeValue <= 0)
        {
            if (GlobalCellManagerScript.percentageOfFull >= 0.5f)
            {
                winner = "joueur 1";
                Debug.Log(winner);
                Debug.Log(PublicVar.GameDuration);
            }
            else
            {
                winner = "joueur 2";
                Debug.Log(winner);
                Debug.Log(PublicVar.GameDuration);
            }
            SceneManager.LoadScene("finalScene");
      
        }
    }
    
     IEnumerator blink()
    {
        yield return new WaitForSeconds(0.5f);
        
          if (timeValue <= 10 && isVisible && timeValue > 0)
        {
            timeText.color = new Color(0, 0, 0, 0);
            isVisible = false;
            StopAllCoroutines();
         
        }
        else if (timeValue <= 10 && !isVisible && timeValue > 0)
        {
            timeText.color = Color.red;
            isVisible = true;
            StopAllCoroutines();
           
        }
    
    }
}
