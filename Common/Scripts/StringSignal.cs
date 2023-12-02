using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(StringSignal))]
    public class StringSignal : Signal<string> { }
}