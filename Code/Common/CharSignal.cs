using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/CharSignal")]
    public class CharSignal : Signal<char, CharEvent> { }
}
