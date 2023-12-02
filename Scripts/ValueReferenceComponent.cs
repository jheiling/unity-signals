using UnityEngine;

namespace Signals
{
    public abstract class ValueReferenceComponent<T> : MonoBehaviour 
    {
        [SerializeField] ValueReference<T> _reference;

        public ValueReference<T> Reference => _reference;

        /// <summary>Implicit cast from the ValueReferenceComponent to the wrapped <see cref="ValueReference"/>.</summary>
        /// <param name="component">The ValueReferenceComponent.</param>
        public static implicit operator ValueReference<T>(ValueReferenceComponent<T> component) => component._reference;

        /// <summary>Implicit cast from the ValueReferenceComponent to the wrapped <see cref="ValueReference.Value"/>.</summary>
        /// <param name="component">The ValueReferenceComponent.</param>
        public static implicit operator T(ValueReferenceComponent<T> component) => component._reference.Value;
    }
}