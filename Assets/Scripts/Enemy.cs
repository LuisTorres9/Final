using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private GameObject healthBar;

    void Start()
    {
        healthBar = GameObject.Find("HealhBar");  
    }

    /*public void Damage ()
     {
        healhBar.SendMessage("TakeDamage",10);
     }*/
}
