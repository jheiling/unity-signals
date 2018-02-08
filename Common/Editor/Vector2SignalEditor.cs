using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(Vector2Signal))]
    public class Vector2SignalEditor : SignalEditor<Vector2, Vector2Event>
    {
        protected override void ValueField(Signal<Vector2, Vector2Event> signal)
        {
            var value = EditorGUILayout.Vector2Field("", signal);
            if (value != signal) signal.Value = value;
        }
    }
}
