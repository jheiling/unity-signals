using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Vector2IntSignal))]
    public class Vector2IntSignal : Signal<Vector2Int> { }
}
