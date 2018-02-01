using UnityEngine;
using Signals.Common;



namespace Signals.Example
{
    [AddComponentMenu("Signals/Example/PositionSignalSetter")]
    public class PositionSignalSetter : MonoBehaviour
    {
        public Vector3Signal Signal;
        Transform _transform;

        void Awake()
        {
            _transform = transform;
        }

        void Update()
        {
            Signal.Value = _transform.position;
        }
    }
}