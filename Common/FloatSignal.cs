using UnityEngine;



namespace Signals
{
    [CreateAssetMenu(menuName = "Signals/FloatSignal")]
    public class FloatSignal : Signal<float, FloatEvent>
    {
        protected override bool HasChanged(float value)
        {
            return Value != value;
        }
    }
}