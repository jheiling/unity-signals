using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/Vector2IntSignal")]
    public class Vector2IntSignal : Signal<Vector2Int, Vector2IntEvent> { }
}
