using UnityEngine;



namespace Signals.Extras.Engine
{
    [CreateAssetMenu(menuName = "Signals/Extras/Engine/ApplicationSettingsSignal")]
    public class ApplicationSettingsSignal : SettingsSignal<ApplicationSettings, ApplicationSettingsEvent> { }
}
