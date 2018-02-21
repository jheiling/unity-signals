using UnityEngine;
using Signals.Common;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/TimeScaleSignalUpdater")]
    public class TimeScaleSignalUpdater : MonoBehaviour
    {
        public FloatSignal Signal;

        void OnEnable()
        {
            UpdateSignal();
        }

        void Update()
        {
            UpdateSignal();
        }

        void UpdateSignal()
        {
            Signal.Value = Time.timeScale;
        }
    }
}