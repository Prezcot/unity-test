using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap_zoom : MonoBehaviour
{
    

    [HideInInspector] public Animator _animator;
    public void Awake()
    {
        _animator = GetComponent<Animator>();
        
    }
    bool value = true;

    public void minimap_zoom_function(){
        value = !value;
        _animator.SetBool("zoom",value);
        Debug.Log(value);
    }


}
