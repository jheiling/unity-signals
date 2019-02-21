using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(FloatSignal), true)]
    public class FloatSignalEditor : SignalEditor<float, FloatEvent>
    {
        protected override float ValueField(float value)
        {
            return EditorGUILayout.DelayedFloatField(value);
        }
    }
}