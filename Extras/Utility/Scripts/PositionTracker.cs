using UnityEngine;
using Signals.Common;

namespace Signals.Extras.Utility
{
    /// <summary>
    /// Tracks the position of a GameObject.
    /// Useful for things like a camera following the player's position from a fixed angle.
    /// </summary>
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Utility) + "/" + nameof(PositionTracker))]
    public class PositionTracker : MonoBehaviour
    {
        [SerializeField] Vector3Signal _signal;
        [SerializeField] bool _local;

        /// <summary>The signal that keeps track of the position.</summary>
        public Vector3Signal Signal
        {
            get => _signal;
            set => _signal = value;
        }

        /// <summary>True to track local instead of global position.</summary>
        public bool Local
        {
            get => _local;
            set => _local = value;
        }

        void Update() { if(_signal) _signal.Value = _local ? transform.localPosition : transform.position; }
    }
}