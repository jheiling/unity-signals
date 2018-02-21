using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/BoolSignal")]
    public class BoolSignal : Signal<bool, BoolEvent> { }
}
