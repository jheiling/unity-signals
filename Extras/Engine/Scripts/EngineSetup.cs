using UnityEngine;
using UnityEngine.Events;

namespace Signals.Extras.Engine
{
    public abstract class EngineSetup<T, ET, ST, VT> : MonoBehaviour, IEngineSettings 
        where T : IEngineSettings, new()
        where ET : UnityEvent<T>, new() 
        where ST : ISignal<T, ET> 
        where VT : ValueReference<T, ET, ST>
    {
#pragma warning disable 649
        [SerializeField] VT _settings;
        [SerializeField] bool _applyOnStart = true;
#pragma warning restore 649

        public VT Settings => _settings;

        public bool ApplyOnStart
        {
            get => _applyOnStart;
            set => _applyOnStart = value;
        }

        public void SetToCurrent()
        {
            if (_settings.Value == null) _settings.Value = new T();
            _settings.Value.SetToCurrent();
        }

        public void Apply() => _settings.Value?.Apply();

        void Start() { if (_applyOnStart) Apply(); }
    }
}