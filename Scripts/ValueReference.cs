using System;
using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    /// <summary>Abstract base class for serializable classes referencing either a <see cref="LocalValue"/> or a <see cref="Signal.Value"/>.</summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="Signal.OnChanged"/> event.</typeparam>
    /// <typeparam name="ST">The type of the Signal.</typeparam>
    public abstract class ValueReference<T, ET, ST> 
        where ET : UnityEvent<T>, new() 
        where ST : ISignal<T, ET>
    {
        [SerializeField] bool _useLocalValue;
        [SerializeField] ST _signal;
        [SerializeField] T _localValue;

        /// <summary>Default constructor.</summary>
        public ValueReference() { }

        /// <summary>Constructor for a ValueReference which uses a <see cref="LocalValue"/>.</summary>
        /// <param name="localValue">The local value.</param>
        public ValueReference(T localValue)
        {
            _useLocalValue = true;
            _localValue = localValue;
        }

        /// <summary>False if a <see cref="Signal"/>'s <see cref="Signal.Value"/> is used, true if <see cref="LocalValue"/> is used.</summary>
        public bool UseLocalValue
        {
            get => _useLocalValue;
            set => _useLocalValue = value;
        }

        /// <summary>The Signal whose <see cref="Signal.Value"/> is used if <see cref="UseLocalValue"/> is false.</summary>
        public ST Signal
        {
            get => _signal;
            set => _signal = value;
        }

        /// <summary>The value which is used if <see cref="UseLocalValue"/> is true.</summary>
        public T LocalValue
        {
            get => _localValue;
            set => _localValue = value;
        }

        /// <summary>The <see cref="Signal.Value"/> of the <see cref="Signal"/> if <see cref="UseLocalValue"/> is false, the <see cref="LocalValue"/> otherwise.</summary>
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
                    if (_signal.Equals(null)) throw new NullReferenceException();
                    return _signal.Value;
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
                    if (_signal.Equals(null)) throw new NullReferenceException();
                    _signal.Value = value;
                }
            }
        }

        /// <summary>Implicit cast from the ValueReference to it's <see cref="Value"/>.</summary>
        /// <param name="reference">The ValueReference.</param>
        public static implicit operator T(ValueReference<T, ET, ST> reference) => reference.Value;
    }
}