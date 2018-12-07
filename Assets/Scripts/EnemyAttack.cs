using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Animator anim;
    public float timeetweenAttacks = 0.5f;
    public int attackDamage = 10;
    GameObject player;
    PlayerHealth playerHealth;
    bool playerRange;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeetweenAttacks && playerRange)
        {
            Attack(); 
        }
        if (playerHealth.currentHealth <= 0)
        {
            Debug.Log("Die");
        }
    }

    void Attack()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }

}
