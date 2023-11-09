using VRBuilder.Core.Properties;

namespace VR_Builder_extentsion
{
    public abstract class ValueProperty<T> : ProcessSceneObjectProperty
    {
        public T PropertyValue { get; set; }

        private IValuePresenter<T> valuePresenter;
        private IValuePresenter<T> ValuePresenter => 
            valuePresenter ??= GetComponent<IValuePresenter<T>>();

        protected override void OnEnable()
        {
            base.OnEnable();

            PropertyValue = ValuePresenter.Value;

            ValuePresenter.ValueChangedEvent += OnValueChanged;
        }

        private void OnDisable()
        {
            ValuePresenter.ValueChangedEvent -= OnValueChanged;
        }

        private void OnValueChanged(object sender, T e)
        {
            PropertyValue = e;
        }
    }
}