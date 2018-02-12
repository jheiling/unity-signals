using UnityEngine;
using UnityEngine.Events;



namespace Signals.Utils.Engine
{
    public abstract class SettingsSignalEditor<T, ET> : SignalEditor<T, ET> where T : class, ISettings where ET : UnityEvent<T>, new()
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
