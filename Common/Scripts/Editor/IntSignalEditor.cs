using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(IntSignal), true)]
    public class IntSignalEditor : SignalEditor<int, IntEvent>
    {
        protected override int ValueField(int value) => EditorGUILayout.DelayedIntField(value);
    }
}
