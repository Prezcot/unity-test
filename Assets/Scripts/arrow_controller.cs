using UnityEngine;

public class arrow_controller : MonoBehaviour
{
    public Transform[] target; // the destination object
    public Camera arCamera; // the AR camera
    public float arrowDistance = 1f; // the distance between the arrow and the camera

    public GameObject arrowObject;

    void Update()
    {
        if (locationDropDownScript.location != 0){
            // get the screen position of the target object
            Vector3 screenPos = arCamera.WorldToScreenPoint(target[locationDropDownScript.location - 1].position);

            // check if the target object is off-screen
            if (screenPos.x < 0 || screenPos.x > Screen.width || screenPos.y < 0 || screenPos.y > Screen.height)
            {
                // calculate the direction towards the target object
                Vector3 direction = target[locationDropDownScript.location - 1].position - arCamera.transform.position;
                direction.y = 0f; // ignore vertical direction

                // set the rotation of the arrow towards the target object
                Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);

                // set the position of the arrow in front of the camera
                Vector3 position = arCamera.transform.position + arCamera.transform.forward * arrowDistance;

                // update the arrow's transform
                arrowObject.transform.position = position;
                arrowObject.transform.rotation = rotation;
                arrowObject.SetActive(true);
            }
            else
            {
                // hide the arrow if the target object is on-screen
                arrowObject.SetActive(false);
            }
        }
    }
}
