using UnityEngine;

namespace Signals.Extras.Engine
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(ApplicationSetup))]
    public class ApplicationSetup : Setup<ApplicationSettings, ApplicationSettingsEvent, ApplicationSettingsSignal, ApplicationSettingsValueReference> { }
}