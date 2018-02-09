using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(BoolSignal))]
    public class BoolSignalEditor : SignalEditor<bool, BoolEvent>
    {
        protected override void ValueField(Signal<bool, BoolEvent> signal)
        {
            var value = EditorGUILayout.Toggle(signal);
            if (value != signal) signal.Value = value;
        }
    }
}
