using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Transform _parenTransform;

    [SerializeField] private float _sensivity = 100.0f;

    private float _rotationX = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SetSensivity(float sens)
    {
        _sensivity = sens;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _sensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _sensivity * Time.deltaTime;

        _rotationX -= mouseY;
        _rotationX = Mathf.Clamp(_rotationX, -90.0f, 90.0f);
        
        _parenTransform.Rotate(Vector3.up * mouseX);
        _cameraTransform.localRotation = Quaternion.Euler(_rotationX, 0f, 0f);
    }
}
