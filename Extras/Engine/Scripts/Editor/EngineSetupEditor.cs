using UnityEngine;
using UnityEditor;

namespace Signals.Extras.Engine
{
    public abstract class EngineSetupEditor<T> : Editor 
        where T : class, IEngineSettings
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (Application.isPlaying)
            {
                if (GUILayout.Button("Set To Current")) (target as T).SetToCurrent();
                if (GUILayout.Button("Apply")) (target as T).Apply();
            }
        }
    }
}