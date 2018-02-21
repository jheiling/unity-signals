﻿using UnityEngine;
using UnityEngine.Events;



namespace Signals.Extras.Engine
{
    public abstract class Setup<T, ET, ST, VT> : MonoBehaviour, ISettings 
        where T : ISettings, new()
        where ET : UnityEvent<T>, new() 
        where ST : ISignal<T, ET> 
        where VT : ValueReference<T, ET, ST>
    {
        [SerializeField] VT _settings;
        [SerializeField] bool _applyOnStart = true;

        public VT Settings
        {
            get
            {
                return _settings;
            }
        }

        public bool ApplyOnStart
        {
            get
            {
                return _applyOnStart;
            }

            set
            {
                _applyOnStart = value;
            }
        }

        void Start()
        {
            if (_applyOnStart) Apply();
        }

        public void SetToCurrent()
        {
            if (_settings.Value == null) _settings.Value = new T();
            _settings.Value.SetToCurrent();
        }

        public void Apply()
        {
            if (_settings.Value != null) _settings.Value.Apply();
        }
    }
}