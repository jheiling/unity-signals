using UnityEngine;

namespace Signals.Extras.Characters
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Characters) + "/" + nameof(RigidbodyCharacterSettingsSignal))]
    public class RigidbodyCharacterSettingsSignal : Signal<RigidbodyCharacterSettings, RigidbodyCharacterSettingsEvent> { }
}
