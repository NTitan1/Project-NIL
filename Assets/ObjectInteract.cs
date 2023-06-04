using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public void OnSelect()
    {
        // Handle the behavior when the object is selected
        Debug.Log("Object selected: " + gameObject.name);
        // Add your custom logic here
    }

    public void OnDeselect()
    {
        // Handle the behavior when the object is deselected
        Debug.Log("Object deselected: " + gameObject.name);
        // Add your custom logic here
    }
}

