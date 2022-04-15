using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ForcedPerspective : MonoBehaviour
{
    [SerializeField] private InputActionReference ForcePerspectiveActionReference;

    private GameObject currentObject;
    private float objectStartDistance;
    private Vector3 objectStartScale;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (currentObject == null)
            {
                //if ()
            }
        }
    }
}
