using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(Vector2IntSignal), true)]
    public class Vector2IntSignalEditor : SignalEditor<Vector2Int, Vector2IntEvent>
    {
        protected override Vector2Int ValueField(Vector2Int value) => EditorGUILayout.Vector2IntField("", value);
    }
}
