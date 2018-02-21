using UnityEngine;
using Signals.Common;



namespace Signals.Extras.Utility
{
    /// <summary>
    /// Tracks the rotation of a GameObject.
    /// </summary>
    [AddComponentMenu("Signals/Extras/Utility/RotationTracker")]
    public class RotationTracker : MonoBehaviour
    {
        [SerializeField] QuaternionSignal _signal;
        [SerializeField] bool _local;
        Transform _transform;

        /// <summary>
        /// The signal that keeps track of the rotation.
        /// </summary>
        public QuaternionSignal Signal
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

        /// <summary>
        /// True to track local instead of global rotation.
        /// </summary>
        public bool Local
        {
            get
            {
                return _local;
            }

            set
            {
                _local = value;
            }
        }

        void Start()
        {
            _transform = transform;
        }

        void Update()
        {
            if(_signal) _signal.Value = _local ? _transform.localRotation : _transform.rotation;
        }
    }
}