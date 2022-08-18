using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roofCellManager : MonoBehaviour
{
    public WeaponController weaponControllerScript;
    public bool isEmpty;

    private void Start()
    {
        weaponControllerScript = GameObject.FindGameObjectWithTag("player1").GetComponent<WeaponController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if(collision.transform.tag == "player1"){
            weaponControllerScript.lastCellRoof = gameObject;
            Debug.Log("Enter in cell" + transform.name);
        }
    }


}
