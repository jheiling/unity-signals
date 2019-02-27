using UnityEditor;

namespace Signals.Extras.Engine
{
    [CustomEditor(typeof(TimeSettingsSignal))]
    public class TimeSettingsSignalEditor : EngineSettingsSignalEditor<TimeSettings, TimeSettingsEvent> { }
}
