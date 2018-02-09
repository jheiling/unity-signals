using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(Vector3Signal))]
    public class Vector3SignalEditor : SignalEditor<Vector3, Vector3Event>
    {
        protected override void ValueField(Signal<Vector3, Vector3Event> signal)
        {
            var value = EditorGUILayout.Vector3Field("", signal);
            if (value != signal) signal.Value = value;
        }
    }
}