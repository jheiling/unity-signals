using UnityEngine;



namespace Signals.Common
{
    [CreateAssetMenu(menuName = "Signals/Vector4Signal")]
    public class Vector4Signal : Signal<Vector4, Vector4Event>
    {
        protected override bool ValidateValue(Vector4 value)
        {
            return Value != value;
        }
    }
}
