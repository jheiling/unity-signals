using UnityEngine;

namespace Signals.Extras.Characters
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Characters) + "/" + nameof(PlayerCharacterInputSettingsSignal))]
    public class PlayerCharacterInputSettingsSignal : Signal<PlayerCharacterInputSettings> { }
}
