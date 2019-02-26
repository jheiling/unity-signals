using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    public abstract class ValueReferenceComponent<T, ET, ST, VT> : MonoBehaviour 
        where ET : UnityEvent<T>, new()
        where ST : ISignal<T, ET>
        where VT : ValueReference<T, ET, ST>
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
        [SerializeField] VT _reference;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        public VT Reference => _reference;

        /// <summary>Implicit cast from the ValueReferenceComponent to the wrapped <see cref="ValueReference"/>.</summary>
        /// <param name="component">The ValueReferenceComponent.</param>
        public static implicit operator VT(ValueReferenceComponent<T, ET, ST, VT> component) => component._reference;

        /// <summary>Implicit cast from the ValueReferenceComponent to the wrapped <see cref="ValueReference.Value"/>.</summary>
        /// <param name="component">The ValueReferenceComponent.</param>
        public static implicit operator T(ValueReferenceComponent<T, ET, ST, VT> component) => component._reference.Value;
    }
}