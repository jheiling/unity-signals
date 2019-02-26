using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Vector2Signal))]
    public class Vector2Signal : Signal<Vector2, Vector2Event> { }
}
