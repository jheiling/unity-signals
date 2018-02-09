using UnityEngine;



namespace Signals.Common
{
    [AddComponentMenu("Signals/StringSignalListener")]
    public class StringSignalListener : SignalListener<string, StringEvent, StringSignal> { }
}