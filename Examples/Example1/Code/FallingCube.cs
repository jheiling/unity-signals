using UnityEngine;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/FallingCube")]
    [RequireComponent(typeof(Rigidbody))]
    public class FallingCube : MonoBehaviour
    {
        public float ResetBelow = -6f;
        public float ResetTo = 6f;
        Rigidbody _rigidbody;

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            if (_rigidbody.position.y < ResetBelow) _rigidbody.position = new Vector3(_rigidbody.position.x, ResetTo, _rigidbody.position.z);
        }
    }
}