using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TargetController : MonoBehaviour
{
  private WeaponController weaponController;
  public Vector2 direction;
  public int speed;
  private Collider2D colliderTarget;
  public Rigidbody2D rb;
  public bool instBall = false;
  public CellManager cellManager;
  private Transform gridManager;
  public GlobalCellManager globalCellManager;


  private void Start()
  {
    weaponController = GameObject.FindGameObjectWithTag("player1").GetComponent<WeaponController>();
    colliderTarget = GameObject.FindGameObjectWithTag("target").GetComponent<Collider2D>();
    gridManager = GameObject.FindGameObjectWithTag("gridManager").GetComponent<Transform>();
    globalCellManager = GameObject.FindGameObjectWithTag("globalCellManager").GetComponent<GlobalCellManager>();

  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.transform.tag == "player2")
    {
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
    if (collision.transform.parent == gridManager)
    {
      Debug.Log("in the grid");
      cellManager = collision.GetComponent<CellManager>();

      Debug.Log(collision.transform.name);
    }
  }
  private void FixedUpdate()
  {

    transform.Translate(direction * speed * Time.fixedDeltaTime);
  }
  public void OnMove(InputAction.CallbackContext ctx)
  {
    if (weaponController.isInAction)
    {
      direction = ctx.ReadValue<Vector2>();
    }
  }
  public void onDelete()
  {
    weaponController.isTargetSpawned = false;
    weaponController.isInAction = false;

    if (cellManager.isEmpty)
    {
      globalCellManager.fullCells++;
      cellManager.isEmpty = false;
    }
    Destroy(gameObject);
  }
}
