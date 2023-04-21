using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{

    static public bool reset = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            reset = true;
            SceneManager.LoadScene("Menu");
        }
    }
}


