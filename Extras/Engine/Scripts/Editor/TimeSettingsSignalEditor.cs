using UnityEditor;

namespace Signals.Extras.Engine
{
    [CustomEditor(typeof(TimeSettingsSignal))]
    public class TimeSettingsSignalEditor : SettingsSignalEditor<TimeSettings, TimeSettingsEvent> { }
}
