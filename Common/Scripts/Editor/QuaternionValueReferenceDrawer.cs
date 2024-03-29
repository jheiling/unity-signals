using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<Quaternion>))]
    public class QuaternionValueReferenceDrawer : ValueReferenceDrawer
    {
        static Vector4 QuaternionToVector4(Quaternion quaternion) => new(quaternion.x, quaternion.y, quaternion.z, quaternion.w);

        static Quaternion Vector4ToQuaternion(Vector4 vector) => new(vector.x, vector.y, vector.z, vector.w);

        protected override void LocalValueField(Rect position, SerializedProperty localValue) => 
            localValue.quaternionValue = Vector4ToQuaternion(EditorGUI.Vector4Field(position, GUIContent.none, QuaternionToVector4(localValue.quaternionValue)));
    }
}
