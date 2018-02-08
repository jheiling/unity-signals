using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/QuaternionSignal")]
    public class QuaternionSignal : Signal<Quaternion, QuaternionEvent>
    {
        protected override bool ValidateValue(Quaternion value)
        {
            return Value != value;
        }
    }
}
