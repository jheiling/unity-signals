using UnityEngine;
using Signals.Common;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/GravityYSignalUpdater")]
    public class GravityYSignalUpdater : MonoBehaviour
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
            Signal.Value = Physics.gravity.y;
        }
    }
}