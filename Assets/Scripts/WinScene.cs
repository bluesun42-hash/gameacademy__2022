using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    public GameObject ScreenWin1;
    public GameObject ScreenWin2;


    string winner = Timer.winner;
    void Start()
    {
        Debug.Log(winner);
        if (winner == "joueur 1")
        {
            ScreenWin1.SetActive(true);
            ScreenWin2.SetActive(false);
        } 
    }

    public void BackToMenu()
    {
        Debug.Log("Game duration " + PublicVar.GameDuration);
        SceneManager.LoadScene("SceneMenu");
    }

    public void PlayAgain()
    {
        Debug.Log("Game duration " + PublicVar.GameDuration);
        SceneManager.LoadScene("Cyril");
    }
}
