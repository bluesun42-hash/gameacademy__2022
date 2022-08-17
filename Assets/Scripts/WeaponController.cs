using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponController : MonoBehaviour
{
  //player 2(D�blayeur)
  public bool isStopped = false;
  public CellManager cellManager;
  public GameObject lastCell;
  private GlobalCellManager globalCellManager;
  public int playerIndex;
  public bool isInAction = false;
  public bool isTargetSpawned = false;
  public GameObject targetPrefab;
  public GameObject targetSpawn;
  public PlayerController playerController;

  private void Start()
  {
    globalCellManager = GameObject.FindGameObjectWithTag("globalCellManager").GetComponent<GlobalCellManager>();
  }
  public int GetPlayerIndex()
  {
    return playerIndex;
  }
  public void OnAction(InputAction.CallbackContext ctx)
  {
    if (ctx.started)
    {
      if (isInAction) {
        switch(playerIndex) {
          case 0: 
          {
            isTargetSpawned = false;
            isInAction = false;
            if (cellManager.isEmpty)
            {
              globalCellManager.fullCells++;
              cellManager.isEmpty = false;
            }
            Destroy(GameObject.FindGameObjectWithTag("target"));
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
                Instantiate(targetPrefab, targetSpawn.transform);
              }
              break;
            }
          case 1:
            {
              isInAction = true;
              StartCoroutine(ThrowingSnow());
              break;
            }
        }
      }
    }

  }

  IEnumerator ThrowingSnow()
  {
    yield return new WaitForSeconds(0);
    if (!cellManager.isEmpty)
    {
      globalCellManager.fullCells--;
      cellManager.isEmpty = true;
    }

    isStopped = false;
  }
}
