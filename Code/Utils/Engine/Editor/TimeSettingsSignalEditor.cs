using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(TimeSettingsSignal))]
    public class TimeSettingsSignalEditor : SettingsSignalEditor<TimeSettings, TimeSettingsEvent> { }
}
