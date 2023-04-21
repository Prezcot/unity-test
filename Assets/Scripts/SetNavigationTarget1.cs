using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SetNavigationTarget1 : MonoBehaviour
{

    [SerializeField] private GameObject[] navtargetobject;



    private NavMeshPath path;
    private LineRenderer line;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
    }

    private void Update()
    {

        //Debug.Log(locationDropDownScript.location);

        // NavMesh.CalculatePath(transform.position, navtargetobject[0].transform.position, NavMesh.AllAreas,path);
        // line.positionCount = path.corners.Length;
        // line.SetPositions (path.corners);
        // line.enabled = true;

        

        if (locationDropDownScript.location != 0){
            //Debug.Log(locationDropDownScript.location);
            NavMesh.CalculatePath(transform.position, navtargetobject[locationDropDownScript.location - 1].transform.position, NavMesh.AllAreas,path);
            line.positionCount = path.corners.Length;
            line.SetPositions (path.corners);
            line.enabled = true;
        }


    }
}

