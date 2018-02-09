using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/Vector2Signal")]
    public class Vector2Signal : Signal<Vector2, Vector2Event>
    {
        protected override bool ValidateValue(Vector2 value)
        {
            return Value != value;
        }
    }
}
