using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TargetController : MonoBehaviour
{

    public CellManager cellManager;
    private Transform gridManager;
    public GlobalCellManager globalCellManager;
    public GameObject snowBallDestroyer;

    private void Start()
    {
        snowBallDestroyer = GameObject.FindGameObjectWithTag("snowBallDestroyer");
        gridManager = GameObject.FindGameObjectWithTag("gridManager").GetComponent<Transform>();
        globalCellManager = GameObject.FindGameObjectWithTag("globalCellManager").GetComponent<GlobalCellManager>();
        GameObject player = GameObject.FindGameObjectWithTag("player2");
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.transform.CompareTag("player2"))
    //    {
    //        Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent == gridManager)
        {
            cellManager = collision.GetComponent<CellManager>();
            Debug.Log("Collision with cell: "+collision.transform.name);
            snowBallDestroyer.transform.position = collision.transform.position;
        }
    }
}
