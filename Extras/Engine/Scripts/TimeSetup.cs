using UnityEngine;



namespace Signals.Extras.Engine
{
    [AddComponentMenu("Signals/Extras/Engine/TimeSetup")]
    public class TimeSetup : Setup<TimeSettings, TimeSettingsEvent, TimeSettingsSignal, TimeSettingsValueReference> { }
}