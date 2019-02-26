using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(StringSignal), true)]
    public class StringSignalEditor : SignalEditor<string, StringEvent>
    {
        protected override string ValueField(string value) => EditorGUILayout.DelayedTextField(value);
    }
}