using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(Vector4Signal))]
    public class Vector4SignalEditor : SignalEditor<Vector4, Vector4Event>
    {
        protected override void ValueField(Signal<Vector4, Vector4Event> signal)
        {
            var value = EditorGUILayout.Vector4Field("", signal);
            if (value != signal) signal.Value = value;
        }
    }
}
