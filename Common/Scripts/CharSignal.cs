using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(CharSignal))]
    public class CharSignal : Signal<char> { }
}
