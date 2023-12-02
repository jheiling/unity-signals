using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(BoolSignal))]
    public class BoolSignal : Signal<bool> { }
}
