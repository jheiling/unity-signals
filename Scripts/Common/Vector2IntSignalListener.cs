using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Vector2IntSignalListener))]
    public class Vector2IntSignalListener : SignalListener<Vector2Int, Vector2IntEvent, Vector2IntSignal> { }
}
