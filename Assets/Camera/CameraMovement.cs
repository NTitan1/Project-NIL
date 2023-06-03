using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 rotateValue;

    public float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }
}
