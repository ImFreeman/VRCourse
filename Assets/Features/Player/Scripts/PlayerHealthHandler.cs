using System;
using System.Collections;
using System.Collections.Generic;
using Features.Enemy.Scripts;
using UnityEngine;

public class PlayerHealthHandler : MonoBehaviour, IValuePresenter<string>
{
    [SerializeField] private EnemyController _controller;
    [SerializeField] private int _health;
    [SerializeField] private string _onDeathMessage;

    private int _currentHealth;
    
    public event EventHandler<string> ValueChangedEvent;
    public string Value { get; set; }

    private void OnEnable()
    {
        _currentHealth = _health;
        _controller.EnemyEnteredEvent += OnEnemyEnteredEvent;
    }

    private void OnEnemyEnteredEvent(object sender, EventArgs e)
    {
        _currentHealth--;
        if (_currentHealth <= 0)
        {
            Value = _onDeathMessage;
            ValueChangedEvent?.Invoke(this, Value);
        }
    }

    private void OnDisable()
    {
        _controller.EnemyEnteredEvent -= OnEnemyEnteredEvent;
    }
}
