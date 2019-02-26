using UnityEngine;
using Signals.Common;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(TimeScaleSignalUpdater))]
    public class TimeScaleSignalUpdater : MonoBehaviour
    {
        public FloatSignal Signal;

        void OnEnable() => UpdateSignal();
        void Update() => UpdateSignal();
        void UpdateSignal() => Signal.Value = Time.timeScale;
    }
}