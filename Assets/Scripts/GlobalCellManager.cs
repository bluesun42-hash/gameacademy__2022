using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCellManager : MonoBehaviour
{
    

    public int cellAmount;
    public int fullCells;
    public float percentageOfFull;
    private void Start()
    {
        cellAmount = 30;
    }
    private void FixedUpdate()
    {
        percentageOfFull = (float)fullCells / (float)cellAmount; 
    }
}
