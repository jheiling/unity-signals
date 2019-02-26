using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Vector3IntSignalListener))]
    public class Vector3IntSignalListener : SignalListener<Vector3Int, Vector3IntEvent, Vector3IntSignal> { }
}
