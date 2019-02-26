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
        [SerializeField] bool _onUpdate = true;
        [SerializeField] bool _onLateUpdate;
        [SerializeField] bool _onFixedUpdate;

        /// <summary>The signal that keeps track of the position.</summary>
        public Vector3Signal Signal { get => _signal; set => _signal = value; }

        /// <summary>True to track local instead of global position.</summary>
        public bool Local { get => _local; set => _local = value; }

        public bool OnUpdate { get => _onUpdate; set => _onUpdate = value; }
        public bool OnLateUpdate { get => _onLateUpdate; set => _onLateUpdate = value; }
        public bool OnFixedUpdate { get => _onFixedUpdate; set => _onFixedUpdate = value; }

        void Update() { if (_onUpdate) SetSignalValue(); }
        void LateUpdate() { if (_onLateUpdate) SetSignalValue(); }
        void FixedUpdate() { if (_onFixedUpdate) SetSignalValue(); }

        void SetSignalValue() { if (_signal) _signal.Value = _local ? transform.localPosition : transform.position; }
    }
}