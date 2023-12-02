using System;
using UnityEngine;

namespace Signals
{
    /// <summary>Serializable class referencing either a <see cref="LocalValue"/> or a <see cref="Signal.Value"/>.</summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    [Serializable]
    public class ValueReference<T> 
    {
        [SerializeField] bool _useLocalValue = true;
        [SerializeField] Signal<T> _signal;
        [SerializeField] T _localValue;

        /// <summary>Default constructor.</summary>
        public ValueReference() { }

        /// <summary>Constructor for a ValueReference which uses a <see cref="LocalValue"/>.</summary>
        /// <param name="localValue">The local value.</param>
        public ValueReference(T localValue) => _localValue = localValue;

        /// <summary>False if a <see cref="Signal"/>'s <see cref="Signal.Value"/> is used, true if <see cref="LocalValue"/> is used.</summary>
        public bool UseLocalValue
        {
            get => _useLocalValue;
            set => _useLocalValue = value;
        }

        /// <summary>The Signal whose <see cref="Signal.Value"/> is used if <see cref="UseLocalValue"/> is false.</summary>
        public Signal<T> Signal
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
            get => _useLocalValue ? _localValue : _signal == null ? throw new NullReferenceException() : _signal.Value;
            set
            {
                if (_useLocalValue)
                {
                    _localValue = value;
                }
                else
                {
                    if (_signal == null) throw new NullReferenceException();
                    _signal.Value = value;
                }
            }
        }

        /// <summary>Implicit cast from the <see cref="ValueReference"/> to it's <see cref="Value"/>.</summary>
        /// <param name="reference">The <see cref="ValueReference"/>.</param>
        public static implicit operator T(ValueReference<T> reference) => reference.Value;
    }
}