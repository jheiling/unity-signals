using UnityEngine;

namespace Signals.Extras.Engine
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(TimeSetup))]
    public class TimeSetup : Setup<TimeSettings, TimeSettingsEvent, TimeSettingsSignal, TimeSettingsValueReference> { }
}