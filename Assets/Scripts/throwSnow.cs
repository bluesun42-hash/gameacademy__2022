using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class throwSnow : MonoBehaviour
{
    //player1(lanceur de boule sde neige)
    public bool isThrowingSnow;
    public GameObject target;
    public GameObject targetSpawn;
    public bool alreadySpawned =false;
   public void onThrowSnow(InputAction.CallbackContext ctx) {
        if (ctx.started && alreadySpawned==false)
        {
            isThrowingSnow = true;
            alreadySpawned = true;
            Instantiate(target, targetSpawn.transform);
        }
    }
}
