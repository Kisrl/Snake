using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour

{
    public float sensitivity = 100.0f;
    public float rotationX = 0.0f;
    public float rotationY = 0.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            rotationX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            rotationY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, -90, 90);

            transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
            transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.down);

           
            
        }

    }
}
