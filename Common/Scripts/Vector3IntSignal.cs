using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Vector3IntSignal))]
    public class Vector3IntSignal : Signal<Vector3Int> { }
}
