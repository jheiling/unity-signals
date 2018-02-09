using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/FloatSignal")]
    public class FloatSignal : Signal<float, FloatEvent>
    {
        protected override bool ValidateValue(float value)
        {
            return Value != value;
        }
    }
}