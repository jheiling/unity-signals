using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    public abstract class ValueReference<T, ET, ST> where ET : UnityEvent<T>, new() where ST : Signal<T, ET>
    {
#if UNITY_EDITOR
        [Multiline] public string Description = "";
#endif
        [SerializeField] bool _useLocalValue;
        [SerializeField] ST _signal;
        [SerializeField] T _localValue;

        public ValueReference() { }

        public ValueReference(T localValue)
        {
            _useLocalValue = true;
            _localValue = localValue;
        }

        public bool UseLocalValue
        {
            get
            {
                return _useLocalValue;
            }

            set
            {
                _useLocalValue = value;
            }
        }

        public ST Signal
        {
            get
            {
                return _signal;
            }

            set
            {
                _signal = value;
            }
        }

        public T LocalValue
        {
            get
            {
                return _localValue;
            }

            set
            {
                _localValue = value;
            }
        }

        public T Value
        {
            get
            {
                if (_useLocalValue)
                {
                    return _localValue;
                }
                else
                {
                    if (!_signal) throw new System.NullReferenceException();
                    return _signal;
                }
            }

            set
            {

                if (_useLocalValue)
                {
                    _localValue = value;
                }
                else
                {
                    if (!_signal) throw new System.NullReferenceException();
                    _signal.Value = value;
                }
            }
        }

        public static implicit operator T(ValueReference<T, ET, ST> reference)
        {
            return reference.Value;
        }
    }
}