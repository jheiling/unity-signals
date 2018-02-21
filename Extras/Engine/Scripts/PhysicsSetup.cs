using UnityEngine;



namespace Signals.Extras.Engine
{
    [AddComponentMenu("Signals/Extras/Engine/PhysicsSetup")]
    public class PhysicsSetup : Setup<PhysicsSettings, PhysicsSettingsEvent, PhysicsSettingsSignal, PhysicsSettingsValueReference> { }
}