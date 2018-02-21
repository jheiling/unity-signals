using UnityEngine;



namespace Signals.Extras.Characters
{
    [CreateAssetMenu(menuName = "Signals/Extras/Characters/RigidbodyCharacterSettingsSignal")]
    public class RigidbodyCharacterSettingsSignal : Signal<RigidbodyCharacterSettings, RigidbodyCharacterSettingsEvent> { }
}
