using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform playerTransform;
    public Vector3 spawn;
    public int jumpForce = 5000;
    public int moveForce = 75000;

    void Start()
    {
        spawn = new Vector3(0, 3, 0);
        rb = GetComponent<Rigidbody>();
        playerTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
        if (Input.GetKey("right"))
        {
            rb.AddForce(new Vector3(moveForce * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(new Vector3(-moveForce * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("up"))
        {
            rb.AddForce(new Vector3(0, 0, moveForce * Time.deltaTime));
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(new Vector3(0, 0, -moveForce * Time.deltaTime));
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(new Vector3(0, jumpForce * Time.deltaTime, 0));
        }

        if (playerTransform.position.y < 0)
        {
            playerTransform.position = spawn;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "store")
        {
            SceneManager.LoadScene("store");
        }
    }

}
