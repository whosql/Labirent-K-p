using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_rotater : MonoBehaviour
{
    public float rotSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float rotx = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotz = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;

            transform.RotateAround(Vector3.up, rotz);

        }
    }
}
