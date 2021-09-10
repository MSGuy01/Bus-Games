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
            if (! isFP)
            {
                Invoke("switchFP(true)", 1);
                playerfollow = new Vector3(0, 4, 0);
            }
            else
            {
                Invoke("switchFP(false)", 1);
                playerfollow = new Vector3(1, 4, -9); 
            }
        }
    }
    void switchFP(bool s)
    {
        isFP = s;
    }
}
