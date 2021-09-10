using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float movementForce = 45f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, 0);
        if (Input.GetKey("right"))
        {
            Debug.Log("right");
            rb.AddForce(new Vector3(75000 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("left"))
        {
            Debug.Log("left");
            rb.AddForce(new Vector3(-75000 * Time.deltaTime, 0, 0));
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

    }

}
