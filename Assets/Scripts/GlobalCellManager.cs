using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCellManager : MonoBehaviour
{
    public GameObject[] Cells;

    public int cellAmount;
    public int fullCells;
    public float percentageOfFull;
    private void Start()
    {
        cellAmount = Cells.Length;
       
        
        
        

        
    }
    private void FixedUpdate()
    {
        percentageOfFull = (float)fullCells / (float)cellAmount;
        Debug.Log(percentageOfFull + "%");
        Debug.Log(fullCells);
    }
}
