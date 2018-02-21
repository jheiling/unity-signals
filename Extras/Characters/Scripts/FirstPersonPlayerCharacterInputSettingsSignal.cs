using UnityEngine;



namespace Signals.Extras.Characters
{
    [CreateAssetMenu(menuName = "Signals/Extras/Characters/FirstPersonPlayerCharacterInputSettingsSignal")]
    public class FirstPersonPlayerCharacterInputSettingsSignal : Signal<FirstPersonPlayerCharacterInputSettings, FirstPersonPlayerCharacterInputSettingsEvent> { }
}
