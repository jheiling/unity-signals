using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Vector2SignalListener))]
    public class Vector2SignalListener : SignalListener<Vector2, Vector2Event, Vector2Signal> { }
}
