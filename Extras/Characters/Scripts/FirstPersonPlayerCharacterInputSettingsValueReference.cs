using System;



namespace Signals.Extras.Characters
{
    [Serializable]
    public class FirstPersonPlayerCharacterInputSettingsValueReference : 
        ValueReference<FirstPersonPlayerCharacterInputSettings, FirstPersonPlayerCharacterInputSettingsEvent, FirstPersonPlayerCharacterInputSettingsSignal>
    {
    public FirstPersonPlayerCharacterInputSettingsValueReference() { }
    public FirstPersonPlayerCharacterInputSettingsValueReference(FirstPersonPlayerCharacterInputSettings localValue) : base(localValue) { }
    }
}
