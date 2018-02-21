using System;



namespace Signals.Extras.Characters
{
    [Serializable]
    public class RigidbodyCharacterSettingsValueReference : 
        ValueReference<RigidbodyCharacterSettings, RigidbodyCharacterSettingsEvent, RigidbodyCharacterSettingsSignal>
    {
    public RigidbodyCharacterSettingsValueReference() { }
    public RigidbodyCharacterSettingsValueReference(RigidbodyCharacterSettings localValue) : base(localValue) { }
    }
}
