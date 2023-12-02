using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Vector4Signal))]
    public class Vector4Signal : Signal<Vector4> { }
}
