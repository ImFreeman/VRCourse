using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private CharacterMovement _characterMovement;
    [SerializeField] private Animator _animator;

    private const float Accuraccy = 0.001f;
    private float _horizontalValue = 0f;
    private float _verticalValue = 0f;

    private void OnEnable()
    {
        _characterMovement.VertiaclMovementEvent += OnVerticalMovementEvent;
        _characterMovement.HorizontalMovementEvent += OnHorizontalMovementEvent;
    }

    private void OnHorizontalMovementEvent(object sender, float e)
    {
        _animator.SetFloat("HorizontalMovement", Mathf.Lerp(_animator.GetFloat("HorizontalMovement"), e, 0.1f));
    }

    private void OnVerticalMovementEvent(object sender, float e)
    {
        _animator.SetFloat("VerticalMovement", Mathf.Lerp(_animator.GetFloat("VerticalMovement"), e, 0.1f));
    }

    private void Update()
    {
        if (Mathf.Abs(_horizontalValue) <= Accuraccy && Mathf.Abs(_verticalValue) <= Accuraccy)
        {
            _animator.SetTrigger("Idle");
        }
    }

    private void OnDisable()
    { 
        _characterMovement.VertiaclMovementEvent -= OnVerticalMovementEvent;
        _characterMovement.HorizontalMovementEvent -= OnHorizontalMovementEvent;
    }
}
