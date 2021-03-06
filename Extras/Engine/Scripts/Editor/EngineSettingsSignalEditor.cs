﻿using UnityEngine;
using UnityEngine.Events;

namespace Signals.Extras.Engine
{
    public abstract class EngineSettingsSignalEditor<T, ET> : SignalEditor<T, ET> 
        where T : class, IEngineSettings 
        where ET : UnityEvent<T>, new()
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
