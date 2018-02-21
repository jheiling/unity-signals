using UnityEngine;



namespace Signals.Extras.Engine
{
    [CreateAssetMenu(menuName = "Signals/Extras/Engine/TimeSettingsSignal")]
    public class TimeSettingsSignal : Signal<TimeSettings, TimeSettingsEvent> { }
}
