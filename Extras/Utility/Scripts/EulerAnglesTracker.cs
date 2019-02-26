using UnityEngine;
using Signals.Common;

namespace Signals.Extras.Utility
{
    /// <summary>Tracks the rotation of a GameObject in euler angles.</summary>
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Utility) + "/" + nameof(EulerAnglesTracker))]
    public class EulerAnglesTracker : MonoBehaviour
    {
        [SerializeField] Vector3Signal _signal;
        [SerializeField] bool _local;
        [SerializeField] bool _trackOnUpdate = true;
        [SerializeField] bool _trackOnLateUpdate;
        [SerializeField] bool _trackOnFixedUpdate;

        /// <summary>The signal that keeps track of the rotation.</summary>
        public Vector3Signal Signal { get => _signal; set => _signal = value; }

        /// <summary>True to track local instead of global rotation.</summary>
        public bool Local { get => _local; set => _local = value; }

        /// <summary>Track on Update?</summary>
        public bool TrackOnUpdate { get => _trackOnUpdate; set => _trackOnUpdate = value; }

        /// <summary>Track on LateUpdate?</summary>
        public bool TrackOnLateUpdate { get => _trackOnLateUpdate; set => _trackOnLateUpdate = value; }

        /// <summary>Track on FixedUpdate?</summary>
        public bool TrackOnFixedUpdate { get => _trackOnFixedUpdate; set => _trackOnFixedUpdate = value; }

        void Update() { if(_trackOnUpdate) SetSignalValue(); }
        void LateUpdate() { if (_trackOnLateUpdate) SetSignalValue(); }
        void FixedUpdate() { if (_trackOnFixedUpdate) SetSignalValue(); }

        void SetSignalValue() { if (_signal) _signal.Value = _local ? transform.localEulerAngles : transform.eulerAngles; }
    }
}