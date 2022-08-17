using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider MasterSlider;

    private void Start()
    {
        MasterSlider.SetValueWithoutNotify(AudioListener.volume);
    }

    public void MasterSliderUpDate()
    {
        AudioListener.volume = MasterSlider.value;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Alex");
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
