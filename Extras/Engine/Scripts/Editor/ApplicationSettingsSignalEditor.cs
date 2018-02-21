using UnityEditor;



namespace Signals.Extras.Engine
{
    [CustomEditor(typeof(ApplicationSettingsSignal))]
    public class ApplicationSettingsSignalEditor : SettingsSignalEditor<ApplicationSettings, ApplicationSettingsEvent> { }
}
