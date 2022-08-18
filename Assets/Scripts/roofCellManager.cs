using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roofCellManager : MonoBehaviour
{
    public WeaponController weaponControllerScript;
    public bool isEmpty;
    public int coolDownTime;
    

    private void Start()
    {
        coolDownTime = 10;
        weaponControllerScript = GameObject.FindGameObjectWithTag("player1").GetComponent<WeaponController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if(collision.transform.tag == "player1"){
            weaponControllerScript.lastCellRoof = gameObject;
            Debug.Log("Enter in cell" + transform.name);
        }
    }
   

   public IEnumerator startCoolDown()
    {
        Debug.Log("cooldown started");
        yield return new WaitForSeconds(coolDownTime);
        Debug.Log("cooldown ended");
        isEmpty = false;
    }

}
