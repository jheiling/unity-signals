using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Vector4SignalListener))]
    public class Vector4SignalListener : SignalListener<Vector4> { }
}
