using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PastaBoxRNG : MonoBehaviour
{
    public GameObject obj;
    public int log;

    int[] xx = new int[2];
    int[] yy = new int[2];

    float x;
    float y;


    System.Random rng = new System.Random();
    
    void Start()
    {
        xx[0] = 13;
        xx[1] =-2;
        yy[0] = 6;
        yy[1] = -6;

        x = rng.Next(xx[1], xx[0]);
        y = rng.Next(yy[1], yy[0]);

        Debug.Log("X:" + x + " Y:" + y);
        Debug.Log(log);
        obj.transform.position = new Vector3(x,y,-2);

        if (rng.Next(1, 11) == 5)
        {
            obj.SetActive(true);
        } else
        {
            obj.SetActive(false);
        }
    }
}
