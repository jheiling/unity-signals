using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(BoolSignal), true)]
    public class BoolSignalEditor : SignalEditor<bool>
    {
        protected override bool ValueField(bool value) => EditorGUILayout.Toggle(value);
    }
}
