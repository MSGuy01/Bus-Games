using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 spawn;
    public int jumpForce = 2000;
    public int moveForce = 75000;
    public GameObject varm;
    public Transform seed;
    public Manager m;
    public Transform sickle;
    public Text loadingText;

    void Start()
    {
        Debug.Log("START");
        spawn = new Vector3(0, 3, 0);
        rb = GetComponent<Rigidbody>();
        varm = GameObject.Find("Variable Manager");
        m = varm.GetComponent<Manager>();
        transform.position = spawn;
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
            if (transform.position.y <= 3)
            {
                rb.AddForce(new Vector3(0, jumpForce * Time.deltaTime, 0));
            }
        }
        if (Input.GetKey("s"))
        {
            if (m.seeds >= 1)
            {
                Debug.Log("use seed");
                Debug.Log(m.seeds);
                m.seeds--;
                Instantiate(seed, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z + 5), Quaternion.identity);
            }
            else {
                Debug.Log("Not enough seeds!");
                Debug.Log(m.seeds);
            }
        }

        if (transform.position.y > 2.4)
        {
            transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z);
        }
        if (transform.position.x < -48 || transform.position.x > 46 || transform.position.z < -48 || transform.position.z > 46)
        {
            transform.position = spawn;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "store")
        {
            loadingText.text = "Loading...";
            DontDestroyOnLoad(varm);
            SceneManager.LoadScene("store");
        }
    }

}
