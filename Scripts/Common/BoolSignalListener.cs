using UnityEngine;



namespace Signals.Common
{
    [AddComponentMenu("Signals/BoolSignalListener")]
    public class BoolSignalListener : SignalListener<bool, BoolEvent, BoolSignal> { }
}
