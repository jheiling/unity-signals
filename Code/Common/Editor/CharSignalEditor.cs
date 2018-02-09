using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(CharSignal))]
    public class CharSignalEditor : SignalEditor<char, CharEvent>
    {
        protected override void ValueField(Signal<char, CharEvent> signal)
        {
            var strValue = EditorGUILayout.DelayedTextField(signal.Value.ToString());
            if(!string.IsNullOrEmpty(strValue) && strValue.Length > 0)
            {
                var value = strValue[0];
                if (value != signal) signal.Value = value;
            }
        }
    }
}
