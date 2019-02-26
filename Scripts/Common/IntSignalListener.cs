using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(IntSignalListener))]
    public class IntSignalListener : SignalListener<int, IntEvent, IntSignal> { }
}
