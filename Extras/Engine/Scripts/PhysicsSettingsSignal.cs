using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(PhysicsSettingsSignal))]
    public class PhysicsSettingsSignal : EngineSettingsSignal<PhysicsSettings> { }
}
