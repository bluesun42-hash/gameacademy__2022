using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public ballSpawn ballSpawnScript;
    public int speed;

    private void Start()
    {
        ballSpawnScript = GameObject.FindGameObjectWithTag("ballSpawn").GetComponent<ballSpawn>();
    }
    private void FixedUpdate()
    {
        transform.Translate(ballSpawnScript.finalDirection * speed *Time.fixedDeltaTime);
       
    }
    public void onDelete()
    {
        Destroy(gameObject);
    }
}
