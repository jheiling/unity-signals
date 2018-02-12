using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/StringSignal")]
    public class StringSignal : Signal<string, StringEvent> { }
}