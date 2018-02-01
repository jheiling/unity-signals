using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(FloatSignal))]
    public class FloatSignalEditor : SignalEditor<float, FloatEvent>
    {
        protected override void ValueField(Signal<float, FloatEvent> signal)
        {
            var value = EditorGUILayout.DelayedFloatField(signal);
            if (value != signal) signal.Value = value;
        }
    }
}