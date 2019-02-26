using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(Vector4ValueReference))]
    public class Vector4ValueReferenceDrawer : ValueReferenceDrawer
    {
        protected override void LocalValueField(Rect position, SerializedProperty localValue) => 
            localValue.vector4Value = EditorGUI.Vector4Field(position, GUIContent.none, localValue.vector4Value);
    }
}
