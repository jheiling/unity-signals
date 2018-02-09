using UnityEngine;



namespace Signals.Common
{
    [AddComponentMenu("Signals/QuaternionSignalListener")]
    public class QuaternionSignalListener : SignalListener<Quaternion, QuaternionEvent, QuaternionSignal> { }
}
