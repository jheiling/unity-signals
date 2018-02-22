using UnityEngine;



namespace Signals.Extras.Characters
{
    [CreateAssetMenu(menuName = "Signals/Extras/Characters/PlayerCharacterInputSettingsSignal")]
    public class PlayerCharacterInputSettingsSignal : Signal<PlayerCharacterInputSettings, PlayerCharacterInputSettingsEvent> { }
}
