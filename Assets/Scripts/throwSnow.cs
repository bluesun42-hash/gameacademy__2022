using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class throwSnow : MonoBehaviour
{
    public bool isThrowingSnow;
    public GameObject target;
    public GameObject targetSpawn;
   public void onThrowSnow(InputAction.CallbackContext ctx) {
        if (ctx.started)
        {
            isThrowingSnow = true;
            Instantiate(target, targetSpawn.transform);
        }
    }
}
