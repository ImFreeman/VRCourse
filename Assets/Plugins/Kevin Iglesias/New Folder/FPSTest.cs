using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSTest : MonoBehaviour
{
    public float sens = 100f;

    public Transform body;

    private float xRoattion = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRoattion -= mouseY;
        xRoattion = Math.Clamp(xRoattion, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRoattion, 0f, 0f);
        body.Rotate(Vector3.up, mouseX);
    }
}
