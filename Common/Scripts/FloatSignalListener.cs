using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(FloatSignalListener))]
    public class FloatSignalListener : SignalListener<float, FloatEvent, FloatSignal> { }
}