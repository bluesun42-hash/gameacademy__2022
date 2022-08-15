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

    private void FixedUpdate()
    {
        rb.velocity = direction * speed * Time.fixedDeltaTime;
        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
    }
    public void onMove(InputAction.CallbackContext ctx)
    {
            direction = ctx.ReadValue<Vector2>();
    }
}