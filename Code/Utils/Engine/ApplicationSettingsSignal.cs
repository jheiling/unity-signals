using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(menuName = "Signals/Utils/Engine/ApplicationSettingsSignal")]
    public class ApplicationSettingsSignal : SettingsSignal<ApplicationSettings, ApplicationSettingsEvent> { }
}
