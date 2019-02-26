using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    /// <summary>Empty Signal. Implements the <see cref="ISignal"/> interface.</summary>
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Signal))]
    public class Signal : ScriptableObject, ISignal
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
#if UNITY_EDITOR
        [SerializeField, Multiline] string _description;
#endif
        [SerializeField] UnityEvent _onUpdated;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        public void AddListener(UnityAction listener) => _onUpdated.AddListener(listener);
        public void RemoveListener(UnityAction listener) => _onUpdated.RemoveListener(listener);
        public void TriggerUpdate() => _onUpdated.Invoke();
    }



    /// <summary>
    /// Abstract base class for Signals inheriting from ScriptableObject.
    /// Implements the <see cref="ISignal"/> interface.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the underlying UnityEvent.</typeparam>
    public abstract class Signal<T, ET> : ScriptableObject, ISignal<T, ET> where ET : UnityEvent<T>, new()
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
#if UNITY_EDITOR
        [SerializeField, Multiline] string _description;
        [SerializeField] bool _serializeChanges;
#endif
        [SerializeField] T _initialValue;
        [SerializeField] ET _onUpdated;
        [SerializeField] bool _useValidation = true;
#pragma warning restore 649, IDE0044 // Add readonly modifier
        T _value;

        /// <summary>The initial value of the Signal.</summary>
        public T InitialValue
        {
            get => _initialValue;
            set
            {
                ProcessValue(ref value);
                if (!_useValidation || ValidateValue(value)) _initialValue = value;
            }
        }

        public T Value
        {
            get => _value;
            set
            {
                ProcessValue(ref value);
                if (!_useValidation || ValidateValue(value))
                {
#if UNITY_EDITOR
                    if (_serializeChanges) _initialValue = value;
#endif
                    _value = value;
                    _onUpdated.Invoke(value);
                }
            }
        }

        /// <summary>True if new values are validated, false otherwise.</summary>
        public bool UseValidation
        {
            get => _useValidation;
            set => _useValidation = value;
        }

        public void AddListener(UnityAction<T> listener) => _onUpdated.AddListener(listener);
        public void RemoveListener(UnityAction<T> listener) => _onUpdated.RemoveListener(listener);
        public void TriggerUpdate() => _onUpdated.Invoke(_value);

        /// <summary>Override this method to preprocess values before applying them.</summary>
        /// <param name="value">The value to process</param>
        protected virtual void ProcessValue(ref T value) { }

        /// <summary>
        /// Override this method to check whether a value is valid and/or if it has changed. 
        /// If <see cref="UseValidation"/> is true the <see cref="Value"/> is set only if this method returns true.
        /// </summary>
        /// <param name="value">The new value.</param>
        /// <returns>Whether the <see cref="Value"/> shoud be updated.</returns>
        protected virtual bool ValidateValue(in T value) => !Equals(value, _value);

        protected virtual void OnEnable() => _value = _initialValue;

        /// <summary>Implicit cast from the <see cref="Signal"/> to it's <see cref="Value"/>.</summary>
        /// <param name="signal">The <see cref="Signal"/>.</param>
        public static implicit operator T(Signal<T, ET> signal) => signal._value;
    }
}