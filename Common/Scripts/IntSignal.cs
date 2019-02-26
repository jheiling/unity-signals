using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(IntSignal))]
    public class IntSignal : Signal<int, IntEvent> { }
}
