using UnityEngine;
using UnityEditor;



namespace Signals.Common
{
    [CustomEditor(typeof(QuaternionSignal))]
    public class QuaternionSignalEditor : SignalEditor<Quaternion, QuaternionEvent>
    {
        protected override void ValueField(Signal<Quaternion, QuaternionEvent> signal)
        {
            var vecValue = EditorGUILayout.Vector4Field("", new Vector4(signal.Value.x, signal.Value.y, signal.Value.z, signal.Value.w));
            var value = new Quaternion(vecValue.x, vecValue.y, vecValue.z, vecValue.w);
            if (value != signal) signal.Value = value;
        }
    }
}
