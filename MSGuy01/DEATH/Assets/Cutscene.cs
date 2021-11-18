using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public Transform coffin;
    // Start is called before the first frame update
    void Start()
    {
        coffin.position = new Vector3(0.64f, 3.76f, -2.24f);
    }

    // Update is called once per frame
    void Update()
    {
        if (coffin.position.y >= 0.88f)
        {
            coffin.position = new Vector3(0.64f, transform.position.y - 0.01f, -2.24f);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
