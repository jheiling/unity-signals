using UnityEngine;



namespace Signals.Extras.Engine
{
    [CreateAssetMenu(menuName = "Signals/Extras/Engine/PhysicsSettingsSignal")]
    public class PhysicsSettingsSignal : SettingsSignal<PhysicsSettings, PhysicsSettingsEvent> { }
}
