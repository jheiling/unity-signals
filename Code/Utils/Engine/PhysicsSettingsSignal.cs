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

        public void SetToCurrent()
        {
            if (Value == null) Value = PhysicsSettings.GetCurrent();
            else Value.SetToCurrent();
        }

        public void Apply()
        {
            if (Value != null) Value.Apply();
        }
    }
}
