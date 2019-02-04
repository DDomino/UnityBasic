using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{


    public float MovementSpeed;
   
    public bool isGrounded;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {

        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z += MovementSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.z -= MovementSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= MovementSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += MovementSpeed * Time.deltaTime;
        }
        transform.position = pos;

    }
}

