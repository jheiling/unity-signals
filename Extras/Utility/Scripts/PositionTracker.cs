using UnityEngine;
using Signals.Common;



namespace Signals.Extras.Utility
{
    /// <summary>
    /// Tracks the position of a GameObject.
    /// Useful for things like a camera following the player's position from a fixed angle.
    /// </summary>
    [AddComponentMenu("Signals/Extras/Utility/PositionTracker")]
    public class PositionTracker : MonoBehaviour
    {
        [SerializeField] Vector3Signal _signal;
        [SerializeField] bool _local;
        Transform _transform;

        /// <summary>
        /// The signal that keeps track of the position.
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
        /// True to track local instead of global position.
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
            if(_signal) _signal.Value = _local ? _transform.localPosition : _transform.position;
        }
    }
}