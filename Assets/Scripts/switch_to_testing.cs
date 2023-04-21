using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switch_to_testing : MonoBehaviour
{
    public void load_ar(){
        SceneManager.LoadScene("testing new floor");
    }
}
