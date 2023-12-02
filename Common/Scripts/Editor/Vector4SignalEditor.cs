using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(Vector4Signal), true)]
    public class Vector4SignalEditor : SignalEditor<Vector4>
    {
        protected override Vector4 ValueField(Vector4 value) => EditorGUILayout.Vector4Field("", value);
    }
}
