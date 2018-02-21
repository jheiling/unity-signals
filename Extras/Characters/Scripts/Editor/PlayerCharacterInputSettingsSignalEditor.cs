using UnityEditor;



namespace Signals.Extras.Characters
{
    [CustomEditor(typeof(FirstPersonPlayerCharacterInputSettingsSignal))]
    public class PlayerCharacterInputSettingsSignalEditor : SignalEditor<FirstPersonPlayerCharacterInputSettings, FirstPersonPlayerCharacterInputSettingsEvent> { }
}
