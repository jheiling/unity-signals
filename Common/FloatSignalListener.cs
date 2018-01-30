using UnityEngine;



namespace Signals
{
    [AddComponentMenu("Signals/FloatSignalListener")]
    public class FloatSignalListener : SignalListener<float, FloatEvent, FloatSignal> { }
}