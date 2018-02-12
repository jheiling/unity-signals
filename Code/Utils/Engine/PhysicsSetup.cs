using UnityEngine;



namespace Signals.Utils.Engine
{
    [AddComponentMenu("Signals/Utils/Engine/PhysicsSetup")]
    public class PhysicsSetup : Setup<PhysicsSettings, PhysicsSettingsEvent, PhysicsSettingsSignal, PhysicsSettingsValueReference> { }
}