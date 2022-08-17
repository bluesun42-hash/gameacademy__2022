using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellManager : MonoBehaviour
{
    public bool isEmpty = true;
    public throwSnowAway throwSnowAwayScript;
    
    public void Start()
    {
        throwSnowAwayScript = GameObject.FindGameObjectWithTag("player2").GetComponent<throwSnowAway>();
        isEmpty = true;
    }
    private void FixedUpdate()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag== "player2")
        {
            throwSnowAwayScript.lastCell = gameObject;
            throwSnowAwayScript.cellManagerScript = transform.GetComponent<cellManager>();
        }
    }

}
