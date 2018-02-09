using UnityEngine;
using Signals.Common;



namespace Signals.Utils
{
    /// <summary>
    /// Tracks the rotation of a GameObject in euler angles.
    /// </summary>
    [AddComponentMenu("Signals/Utils/EulerAnglesTracker")]
    public class EulerAnglesTracker : MonoBehaviour
    {
        [SerializeField] Vector3Signal _signal;
        [SerializeField] bool _local;
        Transform _transform;

        /// <summary>
        /// The signal that keeps track of the rotation.
        /// </summary>
        public Vector3Signal Signal
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
            if(_signal) _signal.Value = _local ? _transform.localEulerAngles : _transform.eulerAngles;
        }
    }
}