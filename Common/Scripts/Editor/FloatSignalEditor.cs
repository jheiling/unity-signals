using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(FloatSignal), true)]
    public class FloatSignalEditor : SignalEditor<float>
    {
        protected override float ValueField(float value) => EditorGUILayout.DelayedFloatField(value);
    }
}