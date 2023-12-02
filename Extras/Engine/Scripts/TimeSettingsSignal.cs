using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(TimeSettingsSignal))]
    public class TimeSettingsSignal : Signal<TimeSettings> { }
}
