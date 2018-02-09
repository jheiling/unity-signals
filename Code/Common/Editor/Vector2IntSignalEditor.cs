using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(Vector2IntSignal))]
    public class Vector2IntSignalEditor : SignalEditor<Vector2Int, Vector2IntEvent>
    {
        protected override void ValueField(Signal<Vector2Int, Vector2IntEvent> signal)
        {
            var value = EditorGUILayout.Vector2IntField("", signal);
            if (value != signal) signal.Value = value;
        }
    }
}
