using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/IntSignal")]
    public class IntSignal : Signal<int, IntEvent> { }
}
