using UnityEngine;



namespace Signals.Utils.Engine
{
    [AddComponentMenu("Signals/Utils/Engine/ApplicationSetup")]
    public class ApplicationSetup : Setup<ApplicationSettings, ApplicationSettingsEvent, ApplicationSettingsSignal, ApplicationSettingsValueReference> { }
}