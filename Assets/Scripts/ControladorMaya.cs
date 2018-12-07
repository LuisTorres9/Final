using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorMaya : MonoBehaviour {

    public NavMeshAgent miAgent;
    public Transform objetivo;
	

	void Start ()
    {
        if (miAgent == null)
        {
            miAgent = this.gameObject.GetComponent<NavMeshAgent>();
        }
		
	}
	
	
	void Update ()
    {
        miAgent.SetDestination(objetivo.position);	
	}
}
