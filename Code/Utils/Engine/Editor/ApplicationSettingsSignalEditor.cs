using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(ApplicationSettingsSignal))]
    public class ApplicationSettingsSignalEditor : SettingsSignalEditor<ApplicationSettings, ApplicationSettingsEvent> { }
}
