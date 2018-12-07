using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public Transform player; 
    UnityEngine.AI.NavMeshAgent enemy;
    private bool dentro = false;

    void Start()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dentro = true; 
        }
    }

    void Update()
    {
        if (!dentro)
        {
            enemy.destination = player.position;
        }
        if (dentro)
        {
            enemy.destination = this.transform.position; 
        }
    }

}
