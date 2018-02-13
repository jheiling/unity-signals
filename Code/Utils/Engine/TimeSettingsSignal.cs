using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(menuName = "Signals/Utils/Engine/TimeSettingsSignal")]
    public class TimeSettingsSignal : Signal<TimeSettings, TimeSettingsEvent> { }
}
