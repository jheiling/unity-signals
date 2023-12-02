using UnityEngine;
using UnityEngine.Events;

namespace Signals.Extras.Engine
{
    public abstract class EngineSettingsSignalEditor<T> : SignalEditor<T> 
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
