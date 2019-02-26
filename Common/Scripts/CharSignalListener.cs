using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(CharSignalListener))]
    public class CharSignalListener : SignalListener<char, CharEvent, CharSignal> { }
}
