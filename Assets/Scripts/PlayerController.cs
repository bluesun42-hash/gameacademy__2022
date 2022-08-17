using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  public int speed;
  public Vector2 direction;
  public Rigidbody2D rb;
  public float rotationSpeed;
  public int playerIndex;
  public WeaponController weaponController;

  public int GetPlayerIndex()
  {
    return playerIndex;
  }
  private void FixedUpdate()
  {
    if (!weaponController.isInAction)
    {
      rb.velocity = direction * speed * Time.fixedDeltaTime;
      if (direction != Vector2.zero)
      {
        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
      }
    }
    else
    {
      rb.velocity = Vector2.zero;
    }
  }
  public void OnMove(InputAction.CallbackContext ctx)
  {
    Debug.Log("OnMove from PC");
    direction = ctx.ReadValue<Vector2>();
  }
}
