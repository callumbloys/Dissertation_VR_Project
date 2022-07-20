using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ForcedPerspective : MonoBehaviour
{
    [SerializeField] InputActionReference ForcePerspectiveActionReference;

    private GameObject currentObject;
    private float objectStartDistanceX;
    private float objectStartDistanceY;
    private float objectStartDistanceZ;

    private float objectScaleX = 10;
    private float objectScaleY = 10;
    private float objectScaleZ = 10;

    private float start_distance;
    private float curr_distance;

    private float objectstartScale;
    private float objectposition;
    public GameObject playerCamera;

    void Start()
    {
        /*objectStartDistanceX = currentObject.transform.position.x;
        objectStartDistanceY = currentObject.transform.position.y;
        objectStartDistanceZ = currentObject.transform.position.z;*/
    }

    void Update()
    {
        /*        RaycastHit hit;

                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
                {
                    if (currentObject == null)
                    {
                        //if ()
                    }
                }*/

        curr_distance = Vector3.Distance(transform.position, playerCamera.transform.position);

        transform.localScale = (transform.localScale / start_distance) * curr_distance;
    }

    void Forcedperspective()
    {
        /*objectScaleX = playerCamera.transform.position.x / currentObject.transform.position.x;
        objectScaleY = playerCamera.transform.position.y / currentObject.transform.position.y;
        objectScaleZ = playerCamera.transform.position.z / currentObject.transform.position.z;*/
        
        

       // transform.localScale = new Vector3(objectScaleX, objectScaleY, objectScaleZ);
    }

    public void Pickup()
    {
        Debug.Log("Picked up");
        start_distance = Vector3.Distance(transform.position, playerCamera.transform.position);
        Forcedperspective();
    }

    public void Drop()
    {
        Debug.Log("Dropped");
    }

}
