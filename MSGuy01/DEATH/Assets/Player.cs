using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int key = 0;
    public float score = 0;
    public float time = 10;
    public Text timeText;
    public Text digText;
    // Start is called before the first frame update
    void Start()
    {
        time = 10;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (Input.GetKey("a"))
        {
            if (key == 0)
            {
                score++;
                key = 1;
            }
        }
        if (Input.GetKey("s"))
        {
            if (key == 1)
            {
                score++;
                key = 0;
            }
        }
        if (score >= 750)
        {
            SceneManager.LoadScene("win");
        }
        if (time <= 0)
        {
            SceneManager.LoadScene("died");
        }
        digText.text = (score/750f)*100 + "% Dug";
        timeText.text = "BREATH LEFT: " + time + " seconds";
        Debug.Log(time);
    }
}
