using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour
{
    public Vector2 playerPos;
    public Vector2 cellPos = new Vector2();
    public Transform playerTrans;
    public Transform cellTrans;
    public bool isShooting;
    public Vector2 directionBall;
    public GameObject snowBall;
    private void Start()
    {
      
        playerTrans = GameObject.FindGameObjectWithTag("ballSpawn").transform;
    }

    private void FixedUpdate()
    {
        if (playerTrans != null)
        {
            playerPos = playerTrans.position;
        }
        if (cellTrans != null)
        {
            cellPos = cellTrans.position;
        }
 
        directionBall = cellPos - playerPos;
        Physics2D.Raycast(playerPos, directionBall);
        Debug.DrawRay(playerPos, directionBall, Color.blue);

        if(isShooting)
        {
            Instantiate(snowBall, transform);
            isShooting = false;
        }

    }

}
