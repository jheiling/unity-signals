using UnityEngine;



namespace Signals.Extras.Engine
{
    [AddComponentMenu("Signals/Extras/Engine/ApplicationSetup")]
    public class ApplicationSetup : Setup<ApplicationSettings, ApplicationSettingsEvent, ApplicationSettingsSignal, ApplicationSettingsValueReference> { }
}