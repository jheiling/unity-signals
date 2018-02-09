using UnityEngine;
using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(PhysicsSettingsSignal))]
    public class PhysicsSettingsSignalEditor : SignalEditor<PhysicsSettings, PhysicsSettingsEvent>
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (Application.isPlaying)
            {
                if (GUILayout.Button("Set To Current")) (target as PhysicsSettingsSignal).SetToCurrent();
                if (GUILayout.Button("Apply")) (target as PhysicsSettingsSignal).Apply();
            }
        }
    }
}
