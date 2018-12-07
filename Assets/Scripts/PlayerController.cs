using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public Transform myTransform;
    [SerializeField] public float speed = 5f;
    private GameObject healthBar;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        healthBar = GameObject.Find("Healthbar");
    }

     void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myTransform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
           
        }

        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
            

        }

    }
}