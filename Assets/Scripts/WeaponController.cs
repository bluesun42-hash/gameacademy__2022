using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
    //player 2(D�blayeur)
    public CellManager cellManager;
    public GameObject lastCell;
    private GlobalCellManager globalCellManager;
    public int playerIndex;
    public int controllerIndex;
    public bool isInAction = false;
    public bool isTargetSpawned = false;
    public GameObject targetPrefab;
    public GameObject targetSpawn;
    public PlayerController playerController;
    public roofCellManager roofCellScript;
    public GameObject lastCellRoof;

    private void Start()
    {
        globalCellManager = GameObject.FindGameObjectWithTag("globalCellManager").GetComponent<GlobalCellManager>();
    }
    public void OnAction(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            if (isInAction)
            {
                switch (playerIndex)
                {
                    case 0:
                        {
                            isTargetSpawned = false;
                            isInAction = false;
                            Debug.Log(cellManager);
                            if (cellManager.isEmpty)
                            {
                                globalCellManager.fullCells++;
                               // cellManager.isEmpty = false;
                                
                                GameObject.FindGameObjectWithTag("ballSpawn").GetComponent<ballSpawn>().isShooting = true;
                                
                                
                                
                            }
                            GameObject target = GameObject.FindGameObjectWithTag("target");
                            Destroy(target);
                            break;
                        }
                }
            }
            else
            {
                switch (playerIndex)
                {
                    case 0:
                        {
                            if (!isTargetSpawned)
                            {
                                isInAction = true;
                                isTargetSpawned = true;
                                GameObject spawned = Instantiate(targetPrefab, targetSpawn.transform);
                                lastCellRoof.GetComponent<roofCellManager>().isEmpty = true;
                                StartCoroutine(lastCellRoof.GetComponent<roofCellManager>().startCoolDown());
                                playerController.target = spawned;
                            }
                            break;
                        }
                    case 1:
                        {
                            isInAction = true;
                           
                            StartCoroutine(RemoveSnow());
                            break;
                        }
                }
            }
        }

    }
    private IEnumerator RemoveSnow()
    {
        yield return new WaitForSeconds(3);
        if (!cellManager.isEmpty)
        {
            globalCellManager.fullCells--;
            cellManager.isEmpty = true;
        }
        isInAction = false;
    }
}
