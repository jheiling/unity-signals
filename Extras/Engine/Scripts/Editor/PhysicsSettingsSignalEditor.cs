using UnityEditor;

namespace Signals.Extras.Engine
{
    [CustomEditor(typeof(PhysicsSettingsSignal))]
    public class PhysicsSettingsSignalEditor : EngineSettingsSignalEditor<PhysicsSettings, PhysicsSettingsEvent> { }
}
