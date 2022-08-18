using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowBallDestroyer : MonoBehaviour
{
    public GameObject snowBall;
    public WeaponController WeaponControllerScript;
    

    private void FixedUpdate()
    {
        snowBall = GameObject.FindGameObjectWithTag("snowBall");
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "snowBall")
        {
            snowBall.GetComponent<BallController>().onDelete();
            WeaponControllerScript.cellManager.isEmpty = false;
        }
    }
}
