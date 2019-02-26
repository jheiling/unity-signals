using UnityEngine;

namespace Signals.Extras.Engine
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(PhysicsSetup))]
    public class PhysicsSetup : Setup<PhysicsSettings, PhysicsSettingsEvent, PhysicsSettingsSignal, PhysicsSettingsValueReference> { }
}