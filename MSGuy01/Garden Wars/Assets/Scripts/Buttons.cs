using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Manager m;
    public GameObject varm;

    void Start()
    {
        varm = GameObject.Find("Variable Manager");
        m = varm.GetComponent<Manager>();
    }

    /*public void colorChange()
    {
        Color c = new Color();
        c = new Vector4(0, 1, 0, 1);
        moneyText.color = c;
    }*/

    public void Play()
    {
        DontDestroyOnLoad(varm);
        SceneManager.LoadScene("Game");
    }

    public void Buy(int item)
    {
        switch (item) {
            //m.seeds
            case 1:
                Debug.Log("m.seeds");
                if (m.money >= 10)
                {
                    m.money -= 10;
                    m.seeds++;
                }
                /*else
                {
                    Color c = new Color();
                    c = new Vector4(1, 0, 0, 1);
                    Debug.Log(moneyText.color);
                    moneyText.color = c;
                    Invoke("colorChange", 1);
                }*/
                break;
            //m.water
            case 2:
                Debug.Log("m.water");
                if (m.money >= 1)
                {
                    m.money--;
                    m.water++;
                }
                /*else
                {
                    Color c = new Color();
                    c = new Vector4(1, 0, 0, 1);
                    Debug.Log(moneyText.color);
                    moneyText.color = c;
                    Invoke("colorChange", 1);
                }*/
                break;
            //this will probably never happen
            default:
                Debug.Log("ERROR: BUTTON DOES NOT EXIST");
                break;
        }
        
    }
}
