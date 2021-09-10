using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    public Vector3 playerfollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = player.position + playerfollow;
        if (Input) {
            Debug.Log("key");
        }
    }
}
