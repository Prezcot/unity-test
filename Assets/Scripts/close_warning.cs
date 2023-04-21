using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_warning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public GameObject warning;

    // Update is called once per frame
    void Update()
    {
       if (back.reset == true){
            warning.SetActive(false);
       }
    }

    public void close_message(){
        warning.SetActive(false);
        
    }
}
