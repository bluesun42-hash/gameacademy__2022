using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
  private PlayerController playerController;
  private WeaponController weaponController;
  private PlayerInput playerInput;

  void Awake()
  {
    playerInput = GetComponent<PlayerInput>();
    var playerControllers = FindObjectsOfType<PlayerController>();
    var weaponControllers = FindObjectsOfType<WeaponController>();
    playerController = Array.Find(playerControllers, e => e.controllerIndex == playerInput.playerIndex);
    weaponController = Array.Find(weaponControllers, e => e.controllerIndex == playerInput.playerIndex);
  }

  public void OnMove(InputAction.CallbackContext ctx)
  {
    
    if (playerController != null) {
        playerController.OnMove(ctx);
    }
  }
  public void OnAction(InputAction.CallbackContext ctx)
  {
    if (weaponController != null) weaponController.OnAction(ctx);
  }
  public void OnPause(InputAction.CallbackContext ctx)
  {
    FindObjectOfType<PauseMenu>()?.OpenCloseUi();
    
  }
}
