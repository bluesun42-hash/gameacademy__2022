using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2Move : MonoBehaviour
{
    public int speed;
    public Vector2 direction;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        rb.velocity = direction * speed * Time.fixedDeltaTime;
    }
    public void onMove(InputAction.CallbackContext ctx)
    {
            direction = ctx.ReadValue<Vector2>();
    }
}
