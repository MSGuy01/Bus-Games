using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    public GameObject mObj;
    public Manager m;

    void Start()
    {
        mObj = GameObject.Find("Variable Manager");
        m = mObj.GetComponent<Manager>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "seed") { }
        if (collision.gameObject.name == "Ground")
        {
            m.poss[m.possIndex] = transform.position;
            m.possIndex++;
            Destroy(this.gameObject);
        }
    }
}
