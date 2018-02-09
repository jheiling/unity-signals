using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/Vector3IntSignal")]
    public class Vector3IntSignal : Signal<Vector3Int, Vector3IntEvent>
    {
        protected override bool ValidateValue(Vector3Int value)
        {
            return Value != value;
        }
    }
}
