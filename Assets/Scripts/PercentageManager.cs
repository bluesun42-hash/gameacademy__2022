using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentageManager : MonoBehaviour
{
    public Slider slider;
    public GlobalCellManager cellManager;
    public Text text;
    private void FixedUpdate()
    {
        slider.value = cellManager.percentageOfFull;
        text.text =Mathf.Floor(cellManager.percentageOfFull *100).ToString() + "%";    
    }
}
