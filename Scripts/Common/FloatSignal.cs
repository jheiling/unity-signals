using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/FloatSignal")]
    public class FloatSignal : Signal<float, FloatEvent> { }
}