using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2Move : MonoBehaviour
{
    public int speed;
    public Vector2 direction;
    public Rigidbody2D rb;
    public float rotationSpeed;
    public throwSnowAway throwSnowAwayScript;

    private void FixedUpdate()
    {
        if (!throwSnowAwayScript.isStopped)
        {
            rb.velocity = direction * speed * Time.fixedDeltaTime;

            if (direction != Vector2.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
            }
        }
    }
    public void onMove(InputAction.CallbackContext ctx)
    {
            direction = ctx.ReadValue<Vector2>();
    }
}
