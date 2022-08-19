using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
    //player 2(D�blayeur)
    [HideInInspector]
    public CellManager cellManager;
    [HideInInspector]
    public GameObject lastCell;
    private GlobalCellManager globalCellManager;
    public int playerIndex;
    [HideInInspector]
    public int controllerIndex;
    [HideInInspector]
    public bool isInAction = false;
    [HideInInspector]
    public bool isTargetSpawned = false;
    public GameObject targetPrefab;
    public GameObject targetSpawn;
    public PlayerController playerController;
    [HideInInspector]
    public GameObject lastCellRoof;
    public int actionCooldown;

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
                            GameObject.FindGameObjectWithTag("ballSpawn").GetComponent<ballSpawn>().isShooting = true;
                            if (cellManager.isEmpty)
                            {
                                globalCellManager.fullCells++;
                         
                                
                                
                                
                                
                                
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
                            if (!isTargetSpawned && !lastCellRoof.GetComponent<roofCellManager>().isEmpty)
                            {
                                isInAction = true;
                                isTargetSpawned = true;
                                GameObject spawned = Instantiate(targetPrefab, targetSpawn.transform);
                                lastCellRoof.GetComponent<roofCellManager>().isEmpty = true;
                                StartCoroutine(lastCellRoof.GetComponent<roofCellManager>().startCoolDown());
                                playerController.target = spawned;
                                GameObject.Find("EnfantDoublageManager").GetComponent<EnfantDoublage>().KidSound();
                            }
                            break;
                        }
                    case 1:
                        {

                            if (!cellManager.isEmpty)
                            {
                                isInAction = true;
                                StartCoroutine(RemoveSnow());
                            }
                            break;
                        }
                }
            }
        }

    }
    private IEnumerator RemoveSnow()
    {
        yield return new WaitForSeconds(actionCooldown);
        if (!cellManager.isEmpty)
        {
            globalCellManager.fullCells--;
            cellManager.isEmpty = true;
        }
        isInAction = false;
    }
}
