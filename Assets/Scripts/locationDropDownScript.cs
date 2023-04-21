using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class locationDropDownScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        goButton.interactable = false;
    }

    static public int location;

    public Button goButton;
    
    public void changeLocation(int val){

            location = val;

        }
        

    

    // Update is called once per frame
    void Update()
    {
        if (back.reset == true){
            location = 0;
            back.reset = false;
        }
        if (location == 0){
            goButton.interactable = false;
        }
        else goButton.interactable = true;
    }
}
