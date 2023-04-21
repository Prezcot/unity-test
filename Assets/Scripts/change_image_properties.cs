using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_image_properties : MonoBehaviour
{
    #region bruh
    
    //public GameObject background;


    //float ax = 168.5f;
    //float ay = -81.161f;
    //float lx = 1;
    //float ly = 1;


    //int work = 0;
    //private void Start()
    //{
    //    Vector2 x = background.GetComponent<RectTransform>().anchoredPosition;
    //    Debug.Log("ax: "+x.x);
    //    Debug.Log("ay: " +x.y);
    //    Vector2 y = background.GetComponent<RectTransform>().localScale;
    //    Debug.Log("lx: " + y.x);
    //    Debug.Log("ly: " + y.y);



    //}

    //public void zoom()
    //{
    //    if (work == 0)
    //    {
    //        work = 1;
    //    }
    //    else work = 0;

    //    //background.GetComponent<RectTransform>().anchoredPosition = Vector3.Lerp(0f, 100f, 2);


    //    //while (true)
    //    //{
    //    //    if (ay >=-1100)
    //    //    {
    //    //        ax = (float)(ax + 0.01);
    //    //        ay = (float)(ay + 0.01);

    //    //        background.GetComponent<RectTransform>().anchoredPosition = new Vector2(ax,ay);
    //    //        if (ax == 800)
    //    //        {
    //    //            ax = 799;
    //    //            break;
    //    //        }


    //    //    }
    //    //    //if (ax == 800)
    //    //    //{
    //    //    //    background.GetComponent<RectTransform>().anchoredPosition = new Vector2(ax, ay--);
    //    //    //    if(ay == -1100)
    //    //    //    {
    //    //    //        break;
    //    //    //    }
    //    //    //}

    //    //}


    //}
    //public void Update()
    //{
    //    //if (work == 1)
    //    //{
    //    //    background.GetComponent<RectTransform>().anchoredPosition = new Vector2(800, -1100);
    //    //    background.GetComponent<RectTransform>().localScale = new Vector2(2, 3);
    //    //    work = 0;

    //    //}



    //    if (work == 0)
    //    {

    //        if (ax > 168.5) ax -= 30;
    //        if (ay < -81.162) ay += 70;

    //        if (lx >1) lx -= 0.05f;
    //        if (ly >1) ly -= 0.1f;

    //        background.GetComponent<RectTransform>().anchoredPosition = new Vector2(ax, ay);
    //        background.GetComponent<RectTransform>().localScale = new Vector2(lx, ly);


    //        //background.GetComponent<RectTransform>().anchoredPosition = new Vector2(ax++, ay--);


    //    }

    //    if (work == 1)
    //    {

    //        if (ax < 800) ax+= 30;
    //        if (ay > -1100) ay -= 70;

    //        if (lx < 2) lx += 0.05f;
    //        if (ly < 3) ly += 0.1f;

    //        background.GetComponent<RectTransform>().anchoredPosition = new Vector2(ax, ay);
    //        background.GetComponent<RectTransform>().localScale = new Vector2(lx, ly);


    //        //background.GetComponent<RectTransform>().anchoredPosition = new Vector2(ax++, ay--);


    //    }

    //}
    #endregion
    [HideInInspector] public Animator _animator;


    //private void Awake()
    //{
    //    _animator = GetComponent<Animator>();
    //    zoomed = false;
    //}

    //public void ZoomInOut()     
    //{
    //    zoomed = !zoomed;
    //    _animator.SetBool("Zoom_FOC", zoomed);
    //}

    public void Awake()
    {
        _animator = GetComponent<Animator>();

    }

    public void zoom_in_out_foc(){
        _animator.SetBool("zoom_foc",true);
        _animator.SetBool("zoom_fob",false);
        _animator.SetBool("zoom_foe",false);
    }
    public void zoom_in_out_fob(){
        
        _animator.SetBool("zoom_fob",true);
        _animator.SetBool("zoom_foc",false);
        _animator.SetBool("zoom_foe",false);

    }
    public void zoom_in_out_foe(){
        
        _animator.SetBool("zoom_foe",true);
        _animator.SetBool("zoom_fob",false);
        _animator.SetBool("zoom_foc",false);
    }    
    
}



