using UnityEngine;



namespace Signals.Utils.Engine
{
    [AddComponentMenu("Signals/Utils/Engine/TimeSetup")]
    public class TimeSetup : Setup<TimeSettings, TimeSettingsEvent, TimeSettingsSignal, TimeSettingsValueReference> { }
}