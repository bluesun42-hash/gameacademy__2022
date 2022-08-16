using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class moveTarget : MonoBehaviour
{
    public throwSnow throwSnowScript;
    public Vector2 direction;
    public int speed;
    public Collider2D colliderTarget;
    public Rigidbody2D rb;
    public bool instBall = false;
    public cellManager cellManagerScript;
    public Transform gridManager;
   
   
    private void Start()
    {
        throwSnowScript = GameObject.FindGameObjectWithTag("player1").GetComponent<throwSnow>();
        colliderTarget = GameObject.FindGameObjectWithTag("target").GetComponent<Collider2D>();
       gridManager = GameObject.FindGameObjectWithTag("gridManager").GetComponent<Transform>();
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag== "player2"){
            colliderTarget.isTrigger = true; 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "player2")
        {
            colliderTarget.isTrigger = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.parent== gridManager)
        {
            Debug.Log("in the grid");
            cellManagerScript = collision.GetComponent<cellManager>();
          
            
            cellManagerScript = collision.GetComponent<cellManager>();
            Debug.Log(collision.transform.name);
        }
    }
    private void FixedUpdate()
    {
        
            transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
    public void onMove(InputAction.CallbackContext ctx)
    {
        if (throwSnowScript.isThrowingSnow)
        {
          direction = ctx.ReadValue<Vector2>();
        }
    }
 public void onDelete()
    {
        throwSnowScript.alreadySpawned = false;
        throwSnowScript.isThrowingSnow = false;
        cellManagerScript.isEmpty = false;
        Destroy(gameObject);
    }
}
