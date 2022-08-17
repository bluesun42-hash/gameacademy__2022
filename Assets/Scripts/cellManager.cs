using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
  public bool isEmpty = true;
  public WeaponController weaponController;

  public void Start()
  {
    weaponController = GameObject.FindGameObjectWithTag("player2").GetComponent<WeaponController>();
    isEmpty = true;
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.transform.tag == "player2")
    {
      weaponController.lastCell = gameObject;
      weaponController.cellManager = transform.GetComponent<CellManager>();
    }
  }

}
