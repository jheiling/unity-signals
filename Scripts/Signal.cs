using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    /// <summary>
    /// Signal with no value.
    /// Implements the <see cref="ISignal"/> interface.
    /// </summary>
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Signal))]
    public class Signal : ScriptableObject, ISignal
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
#if UNITY_EDITOR
        [SerializeField, Multiline] string _description;
#endif
        [SerializeField] UnityEvent _onTriggered;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        /// <summary>Invoked when <see cref="Trigger"/> is called.</summary>
        public UnityEvent OnTriggered => _onTriggered;

        /// <summary>Triggers the <see cref="OnTriggered"/> event.</summary>
        public void Trigger() => _onTriggered.Invoke();
    }

    /// <summary>
    /// Abstract base class for Signals inheriting from ScriptableObject.
    /// Implements the <see cref="ISignal"/> interface.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="OnChanged"/> event.</typeparam>
    public abstract class Signal<T, ET> : ScriptableObject, ISignal<T, ET> where ET : UnityEvent<T>, new()
    {
#if UNITY_EDITOR
#pragma warning disable 649, IDE0044 // Add readonly modifier
        [SerializeField, Multiline] string _description;
        [SerializeField] bool _serializeChanges;
#pragma warning restore 649, IDE0044 // Add readonly modifier
#endif
        [SerializeField] T _initialValue;
        [SerializeField] ET _onChanged;
        [SerializeField] bool _useValidation = true;
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

        /// <summary>
        /// The current value of the Signal. 
        /// Setting the value triggers the <see cref="OnChanged"/> event. 
        /// If you want to add a check before setting the value and triggering the event override the <see cref="ValidateValue"/> method and make sure <see cref="UseValidation"/> is true.
        /// </summary>
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
                    _onChanged.Invoke(value);
                }
            }
        }

        /// <summary>The event invoked when a <see cref="Value"/> is assigned to the Signal.</summary>
        public ET OnChanged => _onChanged;

        /// <summary>True if new values are validated, false otherwise.</summary>
        public bool UseValidation
        {
            get => _useValidation;
            set => _useValidation = value;
        }

        /// <summary>Triggers the <see cref="OnChanged"/> event with the current value.</summary>
        public void ForceChange() => _onChanged.Invoke(_value);

        /// <summary>Override this method to preprocess values before applying them.</summary>
        /// <param name="value">The value to process</param>
        protected virtual void ProcessValue(ref T value) { }

        /// <summary>
        /// Override this method to check whether a value is valid and/or if it has changed. 
        /// If <see cref="UseValidation"/> is true the <see cref="Value"/> is set and the <see cref="OnChanged"/> event is invoked only if this method returns true.
        /// </summary>
        /// <param name="value">The new value.</param>
        /// <returns>True if the <see cref="Value"/> shoud be updated and the <see cref="OnChanged"/> event should be triggered, false otherwise.</returns>
        protected virtual bool ValidateValue(T value) => !_value.Equals(value);

        protected virtual void OnEnable()
        {
            _value = _initialValue;
            if (_onChanged == null) _onChanged = new ET();
        }

        /// <summary>
        /// Implicit cast from the Signal to it's <see cref="Value"/>.
        /// </summary>
        /// <param name="signal">The Signal.</param>
        public static implicit operator T(Signal<T, ET> signal) => signal._value;

        /// <summary>
        /// Implicit cast from the Signal to it's <see cref="OnChanged"/> Event.
        /// </summary>
        /// <param name="signal">The Signal.</param>
        public static implicit operator ET(Signal<T, ET> signal) => signal._onChanged;
    }
}