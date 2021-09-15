using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Manager m;
    public Text moneyText;
    public GameObject varm;
    public Text invText;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Money: $" + m.money;
        invText.text = "Seeds: " + m.seeds + " | Water: " + m.water;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void colorChange()
    {
        Color c = new Color();
        c = new Vector4(0, 1, 0, 1);
        moneyText.color = c;
    }
    public void Play()
    {
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
                    moneyText.text = "Money: $" + m.money;
                    invText.text = "Seeds: " + m.seeds + " | Water: " + m.water;
                }
                else
                {
                    Color c = new Color();
                    c = new Vector4(1, 0, 0, 1);
                    Debug.Log(moneyText.color);
                    moneyText.color = c;
                    Invoke("colorChange", 1);
                }
                break;
            //m.water
            case 2:
                Debug.Log("m.water");
                if (m.money >= 1)
                {
                    m.money--;
                    m.water++;
                    moneyText.text = "Money: $" + m.money;
                    invText.text = "Seeds: " + m.seeds + " | Water: " + m.water;
                }
                else
                {
                    Color c = new Color();
                    c = new Vector4(1, 0, 0, 1);
                    Debug.Log(moneyText.color);
                    moneyText.color = c;
                    Invoke("colorChange", 1);
                }
                break;
            //return
            case 3:
                DontDestroyOnLoad(varm);
                SceneManager.LoadScene("game");
                break;
            //this will probably never happen
            default:
                Debug.Log("ERROR: BUTTON DOES NOT EXIST");
                break;
        }
        
    }
}
