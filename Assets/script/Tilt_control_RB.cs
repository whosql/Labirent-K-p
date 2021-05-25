using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt_control_RB : MonoBehaviour
{
    private Rigidbody rb;
    public float rotSpeed = 20;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        rb.transform.RotateAround(Vector3.right, roty);
        rb.transform.RotateAround(Vector3.back, rotx);


    }
}
