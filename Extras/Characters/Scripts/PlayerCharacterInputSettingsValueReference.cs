using System;

namespace Signals.Extras.Characters
{
    [Serializable]
    public class PlayerCharacterInputSettingsValueReference : 
        ValueReference<PlayerCharacterInputSettings, PlayerCharacterInputSettingsEvent, PlayerCharacterInputSettingsSignal>
    {
    public PlayerCharacterInputSettingsValueReference() { }
    public PlayerCharacterInputSettingsValueReference(PlayerCharacterInputSettings localValue) : base(localValue) { }
    }
}
