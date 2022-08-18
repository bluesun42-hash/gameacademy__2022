using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text text;
    public Slider MasterSlider;

    string purcent;

    private void Start()
    {
        MasterSlider.value = PublicVar.MasterVol * 100;
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
        SceneManager.LoadScene("SceneMenu");
    }

    public void QuitGame ()
    {
       
        Application.Quit();
    }
}
