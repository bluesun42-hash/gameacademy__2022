using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public int controllerIndex;
    public int speed = 200;
    public int targetSpeed = 300;
    public Vector2 direction;
    public Rigidbody2D rb;
    public float rotationSpeed;
    public int playerIndex;
    public WeaponController weaponController;
    public GameObject target;
    public roofCellManager roofCellManagerScript;
    private Animator animator;

    private void Start() {
            animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (!weaponController.isInAction)
        {
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
            animator.SetFloat("Speed", direction.sqrMagnitude);
            rb.velocity = direction * speed * Time.fixedDeltaTime;

            if (direction != Vector2.zero)
            {
                animator.SetFloat("LastHorizontal", direction.x);
                animator.SetFloat("LastVertical", direction.y);
                Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
            if (target) target.GetComponent<Rigidbody2D>().velocity = direction * targetSpeed * Time.fixedDeltaTime;
        }
    }
    public void OnMove(InputAction.CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>();
    }
   
}
