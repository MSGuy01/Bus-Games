using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public Text text;
    public GameObject mObj;
    public Manager m;
    // Start is called before the first frame update
    void Start()
    {
        mObj = GameObject.Find("Variable Manager");
        m = mObj.GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(this.gameObject.name.ToString())
        {
            case "InventoryText":
                text.text = "Seeds: " + m.seeds + " | Water: " + m.water;
                break;
            case "Money":
                text.text = "Money: $" + m.money;
                break;
            default:
                Debug.Log("text does not exist");
                break;
        }
    }
}
