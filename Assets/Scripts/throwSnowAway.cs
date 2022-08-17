using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class throwSnowAway : MonoBehaviour
{
    //player 2(Déblayeur)
    public bool isStopped = false;
    public cellManager cellManagerScript;
    public GameObject lastCell;
    public GlobalCellManager globalCellManagerScript;
    private void Start()
    {
        globalCellManagerScript = GameObject.FindGameObjectWithTag("globalCellManager").GetComponent<GlobalCellManager>();
    }
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
        yield return new WaitForSeconds(0);
        if (!cellManagerScript.isEmpty)
        {
            globalCellManagerScript.fullCells--;
            cellManagerScript.isEmpty = true;
        }
                
        isStopped = false;
    }
}
