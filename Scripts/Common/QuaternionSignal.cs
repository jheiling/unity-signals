using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(QuaternionSignal))]
    public class QuaternionSignal : Signal<Quaternion, QuaternionEvent> { }
}
