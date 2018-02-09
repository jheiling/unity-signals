using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(StringSignal))]
    public class StringSignalEditor : SignalEditor<string, StringEvent>
    {
        protected override void ValueField(Signal<string, StringEvent> signal)
        {
            var value = EditorGUILayout.DelayedTextField(signal);
            if (value != signal) signal.Value = value;
        }
    }
}