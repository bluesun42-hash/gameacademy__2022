using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class setButtonActive : MonoBehaviour
{

    public GameObject menuParam;
    public GameObject mainMenu;
    public GameObject slider1;
    public GameObject playButton;
 public void  onClick()
    {
        menuParam.SetActive(false);
        mainMenu.SetActive(true);
     
        EventSystem.current.SetSelectedGameObject(slider1);
        Debug.Log(EventSystem.current);
    }
    public void onClick2()
    {
        menuParam.SetActive(true);
       mainMenu.SetActive(false);
        
        EventSystem.current.SetSelectedGameObject(playButton);
    }
}
