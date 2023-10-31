using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Transform _bodyTransform;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed = 10.0f;

    public event EventHandler<float> HorizontalMovementEvent;
    public event EventHandler<float> VertiaclMovementEvent;

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        VertiaclMovementEvent?.Invoke(this, y);
        HorizontalMovementEvent?.Invoke(this, x);

        Vector3 move = _bodyTransform.right * x + transform.forward * y;
        _characterController.Move(move * _speed * Time.deltaTime);
    }
}
