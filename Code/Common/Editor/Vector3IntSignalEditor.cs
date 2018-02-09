using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(Vector3IntSignal))]
    public class Vector3IntSignalEditor : SignalEditor<Vector3Int, Vector3IntEvent>
    {
        protected override void ValueField(Signal<Vector3Int, Vector3IntEvent> signal)
        {
            var value = EditorGUILayout.Vector3IntField("", signal);
            if (value != signal) signal.Value = value;
        }
    }
}
