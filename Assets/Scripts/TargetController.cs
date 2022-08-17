using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TargetController : MonoBehaviour
{

    public CellManager cellManager;
    private Transform gridManager;
    public GlobalCellManager globalCellManager;

    private void Start()
    {
        gridManager = GameObject.FindGameObjectWithTag("gridManager").GetComponent<Transform>();
        globalCellManager = GameObject.FindGameObjectWithTag("globalCellManager").GetComponent<GlobalCellManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "player2")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent == gridManager)
        {
            Debug.Log("in the grid");
            cellManager = collision.GetComponent<CellManager>();

            Debug.Log(collision.transform.name);
        }
    }
}
