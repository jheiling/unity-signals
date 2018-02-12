using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/QuaternionSignal")]
    public class QuaternionSignal : Signal<Quaternion, QuaternionEvent> { }
}
