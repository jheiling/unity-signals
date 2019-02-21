using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(Vector3Signal), true)]
    public class Vector3SignalEditor : SignalEditor<Vector3, Vector3Event>
    {
        protected override Vector3 ValueField(Vector3 value)
        {
            return EditorGUILayout.Vector3Field("", value);
        }
    }
}