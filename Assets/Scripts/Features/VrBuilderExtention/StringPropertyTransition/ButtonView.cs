using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour, IValuePresenter<string>
{
    [SerializeField] private Button _button;
    [SerializeField] private string _value;
    
    public event EventHandler<string> ValueChangedEvent;
    public string Value { get; set; }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Value = _value;
        ValueChangedEvent?.Invoke(this, Value);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }
}
