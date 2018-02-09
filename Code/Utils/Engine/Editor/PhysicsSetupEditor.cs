using UnityEngine;
using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(PhysicsSetup))]
    public class PhysicsSetupEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (Application.isPlaying && GUILayout.Button("Apply")) (target as PhysicsSetup).Apply();
        }
    }
}