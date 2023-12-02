using UnityEngine;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(GravityYSignalUpdater))]
    public class GravityYSignalUpdater : MonoBehaviour
    {
        public Signal<float> Signal;

        void OnEnable() => UpdateSignal();
        void Update() => UpdateSignal();
        void UpdateSignal() => Signal.Value = Physics.gravity.y;
    }
}