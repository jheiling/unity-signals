using UnityEngine;
using UnityEditor;



namespace Signals
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