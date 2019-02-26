using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(CharSignal), true)]
    public class CharSignalEditor : SignalEditor<char, CharEvent>
    {
        protected override char ValueField(char value)
        {
            var strValue = EditorGUILayout.DelayedTextField(value.ToString());
            return !string.IsNullOrEmpty(strValue) && strValue.Length > 0 ? strValue[0] : value;
        }
    }
}
