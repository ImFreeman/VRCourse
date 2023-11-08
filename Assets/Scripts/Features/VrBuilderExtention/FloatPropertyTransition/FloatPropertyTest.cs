using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatPropertyTest : MonoBehaviour, IValuePresenter<float>
{
    [SerializeField] private float currentValue;
    
    public event EventHandler<float> ValueChangedEvent;
    public float Value { get; set; }

    private void Update()
    {
        Value = currentValue;
        ValueChangedEvent?.Invoke(this, Value);
    }
}
