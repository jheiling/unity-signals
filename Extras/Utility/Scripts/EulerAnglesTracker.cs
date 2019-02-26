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
        [SerializeField] bool _onUpdate = true;
        [SerializeField] bool _onLateUpdate;
        [SerializeField] bool _onFixedUpdate;

        /// <summary>The signal that keeps track of the rotation.</summary>
        public Vector3Signal Signal { get => _signal; set => _signal = value; }

        /// <summary>True to track local instead of global rotation.</summary>
        public bool Local { get => _local; set => _local = value; }

        public bool OnUpdate { get => _onUpdate; set => _onUpdate = value; }
        public bool OnLateUpdate { get => _onLateUpdate; set => _onLateUpdate = value; }
        public bool OnFixedUpdate { get => _onFixedUpdate; set => _onFixedUpdate = value; }

        void Update() { if(_onUpdate) SetSignalValue(); }
        void LateUpdate() { if (_onLateUpdate) SetSignalValue(); }
        void FixedUpdate() { if (_onFixedUpdate) SetSignalValue(); }

        void SetSignalValue() { if (_signal) _signal.Value = _local ? transform.localEulerAngles : transform.eulerAngles; }
    }
}