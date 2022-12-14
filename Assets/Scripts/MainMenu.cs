using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public Text text;
    public Slider MasterSlider;
    public GameObject playButton;

    string purcent;

    private void Start()
    {
        MasterSlider.value = PublicVar.MasterVol * 100;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(playButton);
    }

    public void MasterSliderUpDate()
    {
        PublicVar.MasterVol = MasterSlider.value/100;
        AudioListener.volume = PublicVar.MasterVol;
        purcent = MasterSlider.value+"%";
        try
        {
            text.text = purcent;
        }
        catch
        {

        }
     
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Cyril");
        //SceneManager.LoadScene("Alex");
    }
    public void GoMenu()    
    {
        AudioListener.volume = PublicVar.MasterVol;
        Debug.Log(AudioListener.volume);
        Time.timeScale = 1;
        SceneManager.LoadScene("SceneMenu");
    }

    public void QuitGame ()
    {
       
        Application.Quit();
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
}
