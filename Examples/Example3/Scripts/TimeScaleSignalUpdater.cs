using UnityEngine;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(TimeScaleSignalUpdater))]
    public class TimeScaleSignalUpdater : MonoBehaviour
    {
        public Signal<float> Signal;

        void OnEnable() => UpdateSignal();
        void Update() => UpdateSignal();
        void UpdateSignal() => Signal.Value = Time.timeScale;
    }
}