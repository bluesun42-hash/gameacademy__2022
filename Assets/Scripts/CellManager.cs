using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
  public bool isEmpty = true;
  private WeaponController weaponController1;
  private WeaponController weaponController2;

  public void Start()
  {
    weaponController1 = GameObject.FindGameObjectWithTag("player1").GetComponent<WeaponController>();
    weaponController2 = GameObject.FindGameObjectWithTag("player2").GetComponent<WeaponController>();
    isEmpty = true;
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.transform.CompareTag("player2"))
    {
      weaponController2.lastCell = gameObject;
      weaponController2.cellManager = transform.GetComponent<CellManager>();
    }
    else if (collision.transform.CompareTag("target"))
    {
      GameObject.FindGameObjectWithTag("ballSpawn").GetComponent<ballSpawn>().cellTrans = transform;
      weaponController1.lastCell = gameObject;
      weaponController1.cellManager = transform.GetComponent<CellManager>();
    }
  }

}
