using UnityEngine;



namespace Signals
{
    [CreateAssetMenu(menuName = "Signals/Vector3Signal")]
    public class Vector3Signal : Signal<Vector3, Vector3Event>
    {
        protected override bool ValidateValue(Vector3 value)
        {
            return Value != value;
        }
    }
}