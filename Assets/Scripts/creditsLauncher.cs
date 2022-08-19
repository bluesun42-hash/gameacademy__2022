using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class creditsLauncher : MonoBehaviour
{
  public void onCLick()
    {
        SceneManager.LoadScene("credits");
    }
}
