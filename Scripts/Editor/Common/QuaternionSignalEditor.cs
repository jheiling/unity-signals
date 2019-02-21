using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(QuaternionSignal), true)]
    public class QuaternionSignalEditor : SignalEditor<Quaternion, QuaternionEvent>
    {
        protected override Quaternion ValueField(Quaternion value)
        {
            var vecValue = EditorGUILayout.Vector4Field("", new Vector4(value.x, value.y, value.z, value.w));
            return new Quaternion(vecValue.x, vecValue.y, vecValue.z, vecValue.w);
        }
    }
}
