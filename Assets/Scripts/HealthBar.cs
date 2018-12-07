using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public float hp, maxHp = 100f;
    public Image healh;
   
    void Start()
    {
        hp = maxHp;
        
    }

    public void TakeDamage(float amount)
    {
        hp = Mathf.Clamp(hp - amount, 0f, maxHp);
        healh.transform.localScale = new Vector2(hp / maxHp, 1);
    }

   
}
