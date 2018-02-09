using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(menuName = "Signals/Utils/Engine/PhysicsSettingsSignal")]
    public class PhysicsSettingsSignal : Signal<PhysicsSettings, PhysicsSettingsEvent>
    {
        protected override bool ValidateValue(PhysicsSettings value)
        {
            return Value != value;
        }
    }
}
