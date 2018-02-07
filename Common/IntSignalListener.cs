using UnityEngine;
using Signals;



namespace Signals.Common
{
    [AddComponentMenu("Signals/IntSignalListener")]
    public class IntSignalListener : SignalListener<int, IntEvent, IntSignal> { }
}
