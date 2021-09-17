using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public Transform c;
    public Rigidbody playerRB;
    public Vector3 playerfollow;
    private bool isFP;

    void Start()
    {
        c = this.GetComponent<Transform>();
        isFP = false;
    }

    void Update()
    {
        c.position = player.position + playerfollow;
        if (Input.GetKey("f"))
        {
            switchFP(false);
        }
        if (Input.GetKey("t"))
        {
            switchFP(true);
        }
    }
    void switchFP(bool s)
    {
        isFP = s;
        if (s)
        {
            playerfollow = new Vector3(1, 4, -9);
        }
        else
        {
            playerfollow = new Vector3(0, 4, 0);
        }
    }
}
