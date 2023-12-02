using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(Vector3IntSignal), true)]
    public class Vector3IntSignalEditor : SignalEditor<Vector3Int>
    {
        protected override Vector3Int ValueField(Vector3Int value) => EditorGUILayout.Vector3IntField("", value);
    }
}
