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

        x = rng.Next(xx[0], xx[1]);
        y = rng.Next(yy[0], yy[1]);

        obj.transform.position = new Vector2(x,y);
    }
}
