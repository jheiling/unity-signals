using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(Vector2Signal), true)]
    public class Vector2SignalEditor : SignalEditor<Vector2>
    {
        protected override Vector2 ValueField(Vector2 value) => EditorGUILayout.Vector2Field("", value);
    }
}
