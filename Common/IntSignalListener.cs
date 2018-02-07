using UnityEngine;



namespace Signals.Common
{
    [AddComponentMenu("Signals/IntSignalListener")]
    public class IntSignalListener : SignalListener<int, IntEvent, IntSignal> { }
}
