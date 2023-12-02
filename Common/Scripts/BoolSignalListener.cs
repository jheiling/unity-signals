using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(BoolSignalListener))]
    public class BoolSignalListener : SignalListener<bool> { }
}
