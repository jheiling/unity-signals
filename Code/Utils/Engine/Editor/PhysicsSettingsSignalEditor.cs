using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(PhysicsSettingsSignal))]
    public class PhysicsSettingsSignalEditor : SignalEditor<PhysicsSettings, PhysicsSettingsEvent> { }
}
