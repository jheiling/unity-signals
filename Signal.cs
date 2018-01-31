using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    public interface ISignal<T, ET> where ET : UnityEvent<T>, new()
    {
        T Value { get; set; }
        ET OnChanged { get; }
    }



    public abstract class Signal<T, ET> : ScriptableObject, ISignal<T, ET> where ET : UnityEvent<T>, new()
    {
#if UNITY_EDITOR
        [Multiline] public string Description = "";
        public bool SerializeChanges;
#endif
        [SerializeField] T _initialValue;
        T _value;
        [SerializeField] ET _onChanged;

        public T InitialValue
        {
            get
            {
                return _initialValue;
            }

            set
            {
                _initialValue = value;
            }
        }

        public T Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (HasChanged(value))
                {
#if UNITY_EDITOR
                    if (SerializeChanges) _initialValue = value;
#endif
                    _value = value;
                    _onChanged.Invoke(value);
                }
            }
        }

        public ET OnChanged
        {
            get
            {
                return _onChanged;
            }
        }

        protected virtual bool HasChanged(T value)
        {
            return true;
        }

        void OnEnable()
        {
            _value = _initialValue;
            if (_onChanged == null) _onChanged = new ET();
        }

        public static implicit operator T(Signal<T, ET> signal)
        {
            return signal.Value;
        }
    }
}