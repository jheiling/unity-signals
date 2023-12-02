using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Vector3SignalListener))]
    public class Vector3SignalListener : SignalListener<Vector3> { }
}