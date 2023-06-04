using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClick : MonoBehaviour
{
    private Camera mainCamera;
    private ObjectInteract lastInteractedObject;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                ObjectInteract objectInteract = hit.collider.GetComponent<ObjectInteract>();

                if (objectInteract != null)
                {
                    // Clicked on an interactable object
                    if (lastInteractedObject != null && lastInteractedObject != objectInteract)
                    {
                        // Deselect the previous object if it exists and is different
                        lastInteractedObject.OnDeselect();
                    }

                    // Select the current object
                    objectInteract.OnSelect();
                    lastInteractedObject = objectInteract;
                }
                else
                {
                    // Clicked on an object without ObjectInteract script or empty space
                    if (lastInteractedObject != null)
                    {
                        // Deselect the previous object
                        lastInteractedObject.OnDeselect();
                        lastInteractedObject = null;
                    }
                }
            }
            else
            {
                // Clicked on empty space
                if (lastInteractedObject != null)
                {
                    // Deselect the previous object
                    lastInteractedObject.OnDeselect();
                    lastInteractedObject = null;
                }
            }
        }
    }
}
