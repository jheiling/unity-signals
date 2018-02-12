using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(PhysicsSettingsSignal))]
    public class PhysicsSettingsSignalEditor : SettingsSignalEditor<PhysicsSettings, PhysicsSettingsEvent> { }
}
