using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigation_bar: MonoBehaviour
{
    private change_image_properties change_Image_Properties;
    private Animator _animator;

    public void Awake()
    {
        change_Image_Properties = GetComponent<change_image_properties>();
        _animator = change_Image_Properties._animator;
    }

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    
    public void panel1_active()
    {
        //_animator.SetBool("zoom_fob",false);
        //_animator.SetBool("zoom_foe",false);
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);

    }
    public void panel2_active()
    {
        //_animator.SetBool("zoom_foc",false);
        //_animator.SetBool("zoom_foe",false);
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);

    }
    public void panel3_active()
    {
        //_animator.SetBool("zoom_fob",false);
        //_animator.SetBool("zoom_foc",false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);

    }

}
