using UnityEngine;
using Signals.Common;

namespace Signals.Extras.Utility
{
    /// <summary>
    /// Tracks the rotation of a GameObject.
    /// </summary>
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Utility) + "/" + nameof(RotationTracker))]
    public class RotationTracker : MonoBehaviour
    {
        [SerializeField] QuaternionSignal _signal;
        [SerializeField] bool _local;

        /// <summary>The signal that keeps track of the rotation.</summary>
        public QuaternionSignal Signal
        {
            get => _signal;
            set => _signal = value;
        }

        /// <summary>True to track local instead of global rotation.</summary>
        public bool Local
        {
            get => _local;
            set => _local = value;
        }

        void Update() { if(_signal) _signal.Value = _local ? transform.localRotation : transform.rotation; }
    }
}