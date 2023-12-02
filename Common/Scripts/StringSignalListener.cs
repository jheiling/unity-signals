using UnityEngine;

namespace Signals.Common
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(StringSignalListener))]
    public class StringSignalListener : SignalListener<string> { }
}