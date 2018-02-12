using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(menuName = "Signals/TimeSettingsSignal")]
    public class TimeSettingsSignal : Signal<TimeSettings, TimeSettingsEvent> { }
}
