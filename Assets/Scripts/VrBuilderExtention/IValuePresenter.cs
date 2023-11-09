using System;

public interface IValuePresenter<T>
{
    event EventHandler<T> ValueChangedEvent;
    T Value { get; set; }
}
