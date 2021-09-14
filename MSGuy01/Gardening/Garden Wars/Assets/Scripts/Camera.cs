using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    public Vector3 playerfollow;
    private bool isFP;

    // Start is called before the first frame update
    void Start()
    {
        isFP = false;
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = player.position + playerfollow;
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
