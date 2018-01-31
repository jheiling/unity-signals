﻿using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    /// <summary>
    /// The Signal interface.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="OnChanged"/> event.</typeparam>
    public interface ISignal<T, ET> where ET : UnityEvent<T>, new()
    {
        /// <summary>
        /// The current value of the Signal. 
        /// Setting the value triggers the <see cref="OnChanged"/> event. 
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// The event invoked when a <see cref="Value"/> is assigned to the Signal.
        /// </summary>
        ET OnChanged { get; }
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
        [Multiline] public string Description = "";
        public bool SerializeChanges;
#endif
        [SerializeField] T _initialValue;
        T _value;
        [SerializeField] ET _onChanged;

        /// <summary>
        /// The initial value of the Signal.
        /// </summary>
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

        /// <summary>
        /// The current value of the Signal. 
        /// Setting the value triggers the <see cref="OnChanged"/> event. 
        /// If you want to add a check before setting the value and triggering the event override the <see cref="ValidateValue"/> method.
        /// </summary>
        public T Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (ValidateValue(value))
                {
#if UNITY_EDITOR
                    if (SerializeChanges) _initialValue = value;
#endif
                    _value = value;
                    _onChanged.Invoke(value);
                }
            }
        }

        /// <summary>
        /// The event invoked when a <see cref="Value"/> is assigned to the Signal.
        /// </summary>
        public ET OnChanged
        {
            get
            {
                return _onChanged;
            }
        }

        /// <summary>
        /// Override this method to check whether a value is valid and/or if it has changed. 
        /// The <see cref="Value"/> is set and the <see cref="OnChanged"/> event is invoked only if this method returns true.
        /// </summary>
        /// <param name="value">The new value.</param>
        /// <returns>True if the <see cref="Value"/> shoud be updated and the <see cref="OnChanged"/> event should be triggered, false otherwise.</returns>
        protected virtual bool ValidateValue(T value)
        {
            return true;
        }

        void OnEnable()
        {
            _value = _initialValue;
            if (_onChanged == null) _onChanged = new ET();
        }

        /// <summary>
        /// Implicit cast from the Signal to it's <see cref="Value"/>.
        /// </summary>
        /// <param name="signal">The Signal.</param>
        public static implicit operator T(Signal<T, ET> signal)
        {
            return signal.Value;
        }
    }
}