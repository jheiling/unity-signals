using UnityEngine;
using Signals.Common;



namespace Signals.Utils
{
    /// <summary>
    /// Tracks the position of a GameObject.
    /// Useful for things like a camera following the player's position from a fixed angle.
    /// </summary>
    [AddComponentMenu("Signals/Utils/PositionTracker")]
    public class PositionTracker : MonoBehaviour
    {
        [SerializeField] Vector3Signal _signal;
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

        void Start()
        {
            _transform = transform;
        }

        void Update()
        {
            if(_signal) _signal.Value = _transform.position;
        }
    }
}