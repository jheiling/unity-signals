using UnityEngine;

namespace Signals.Common
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Vector3Signal))]
    public class Vector3Signal : Signal<Vector3, Vector3Event> { }
}