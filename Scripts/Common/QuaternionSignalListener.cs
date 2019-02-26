using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(QuaternionSignalListener))]
    public class QuaternionSignalListener : SignalListener<Quaternion, QuaternionEvent, QuaternionSignal> { }
}
