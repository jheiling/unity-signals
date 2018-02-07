using UnityEngine;
using Signals;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/IntSignal")]
    public class IntSignal : Signal<int, IntEvent>
    {
        protected override bool ValidateValue(int value)
        {
            return Value != value;
        }
    }
}
