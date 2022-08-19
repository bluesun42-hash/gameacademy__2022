using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PastaBoxRNG : MonoBehaviour
{
    public GameObject obj;

    int[] xx = new int[2];
    int[] yy = new int[2];

    float x;
    float y;


    System.Random rng = new System.Random();
    
    void Start()
    {
        xx[0] = 42;
        xx[1] = -28;
        yy[0] = 28;
        yy[1] = -46;

        x = rng.Next(xx[1], xx[0]);
        y = rng.Next(yy[1], yy[0]);

        Debug.Log("X:" + x + " Y:" + y);
        obj.transform.position = new Vector2(x,y);

        if (rng.Next(1, 69) == 42)
        {
            obj.SetActive(true);
        } else
        {
            obj.SetActive(false);
        }
    }
}
