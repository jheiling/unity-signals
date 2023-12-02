using UnityEngine;

namespace Signals.Extras.Utility
{
    /// <summary>
    /// Tracks the position of a GameObject.
    /// Useful for things like a camera following the player's position from a fixed angle.
    /// </summary>
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Utility) + "/" + nameof(PositionTracker))]
    public class PositionTracker : MonoBehaviour
    {
        [SerializeField] Signal<Vector3> _signal;
        [SerializeField] bool _local;
        [SerializeField] bool _trackOnUpdate = true;
        [SerializeField] bool _trackOnLateUpdate;
        [SerializeField] bool _trackOnFixedUpdate;

        /// <summary>The signal that keeps track of the position.</summary>
        public Signal<Vector3> Signal { get => _signal; set => _signal = value; }

        /// <summary>True to track local instead of global position.</summary>
        public bool Local { get => _local; set => _local = value; }

        /// <summary>Track on Update?</summary>
        public bool TrackOnUpdate { get => _trackOnUpdate; set => _trackOnUpdate = value; }

        /// <summary>Track on LateUpdate?</summary>
        public bool TrackOnLateUpdate { get => _trackOnLateUpdate; set => _trackOnLateUpdate = value; }

        /// <summary>Track on FixedUpdate?</summary>
        public bool TrackOnFixedUpdate { get => _trackOnFixedUpdate; set => _trackOnFixedUpdate = value; }

        void Update() { if (_trackOnUpdate) SetSignalValue(); }
        void LateUpdate() { if (_trackOnLateUpdate) SetSignalValue(); }
        void FixedUpdate() { if (_trackOnFixedUpdate) SetSignalValue(); }

        void SetSignalValue() { if (_signal) _signal.Value = _local ? transform.localPosition : transform.position; }
    }
}