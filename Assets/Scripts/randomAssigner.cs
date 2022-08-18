using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class randomAssigner : MonoBehaviour
{
    public PlayerInputManager playerInputManager;
    public int randValue;
  
    private void Start()
    {

        randValue = Random.Range(0, 2);
        Debug.Log(randValue);
        GameObject player1 = GameObject.FindGameObjectWithTag("player1");
        GameObject player2 = GameObject.FindGameObjectWithTag("player2");
        player1.GetComponent<PlayerController>().controllerIndex = randValue;
        player1.GetComponent<WeaponController>().controllerIndex = randValue;
        player2.GetComponent<PlayerController>().controllerIndex = randValue == 0 ? 1 : 0;
        player2.GetComponent<WeaponController>().controllerIndex = randValue == 0 ? 1 : 0;
    }
}
