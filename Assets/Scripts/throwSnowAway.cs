using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class throwSnowAway : MonoBehaviour
{
    //player 2(Déblayeur)
    public bool isStopped = false;
 public void onThrowSnowAway(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            isStopped = true;
            StartCoroutine(ThrowingSnow());

           
        }
    }

    IEnumerator ThrowingSnow()
    {
        yield return new WaitForSeconds(3);
        
        isStopped = false;
    }
}
