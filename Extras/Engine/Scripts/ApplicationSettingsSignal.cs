using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(ApplicationSettingsSignal))]
    public class ApplicationSettingsSignal : SettingsSignal<ApplicationSettings, ApplicationSettingsEvent> { }
}
