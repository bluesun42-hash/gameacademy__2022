using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Cyril");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("SceneMenu");
    }

    public void QuitGame ()
    {
        Debug.Log("Plus la");
        Application.Quit();
    }
}
