using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(FloatSignal))]
    public class FloatSignalEditor : SignalEditor<float, FloatEvent>
    {
        protected override void ValueField(Signal<float, FloatEvent> signal)
        {
            signal.Value = EditorGUILayout.DelayedFloatField(signal.Value);
        }
    }
}