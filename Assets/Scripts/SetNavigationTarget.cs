using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SetNavigationTarget : MonoBehaviour
{

    [SerializeField] private Camera topdownview;

    [SerializeField] private GameObject navtargetobject;




    [SerializeField] private GameObject start;

    private NavMeshPath path;
    private LineRenderer line;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
    }
        
    private void Update()
    {
        NavMesh.CalculatePath(transform.position, navtargetobject.transform.position, NavMesh.AllAreas,path);
        line.positionCount = path.corners.Length;
        line.SetPositions (path.corners);
        line.enabled = true;
    }
}

