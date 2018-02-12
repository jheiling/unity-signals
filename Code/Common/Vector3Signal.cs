using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/Vector3Signal")]
    public class Vector3Signal : Signal<Vector3, Vector3Event> { }
}