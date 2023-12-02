using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(FloatSignal))]
    public class FloatSignal : Signal<float> { }
}