using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(BoolSignal), true)]
    public class BoolSignalEditor : SignalEditor<bool, BoolEvent>
    {
        protected override bool ValueField(bool value) => EditorGUILayout.Toggle(value);
    }
}
