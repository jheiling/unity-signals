using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(IntSignal))]
    public class IntSignalEditor : SignalEditor<int, IntEvent>
    {
        protected override void ValueField(Signal<int, IntEvent> signal)
        {
            var value = EditorGUILayout.DelayedIntField(signal);
            if (value != signal) signal.Value = value;
        }
    }
}
