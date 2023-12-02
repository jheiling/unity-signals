using UnityEngine;

namespace Signals.Extras.Engine
{
    public abstract class EngineSetup<T> : MonoBehaviour, IEngineSettings 
        where T : IEngineSettings, new()
    {
        [SerializeField] ValueReference<T> _settings;
        [SerializeField] bool _applyOnStart = true;

        public ValueReference<T> Settings => _settings;

        public bool ApplyOnStart
        {
            get => _applyOnStart;
            set => _applyOnStart = value;
        }

        public void SetToCurrent()
        {
            _settings.Value ??= new T();
            _settings.Value.SetToCurrent();
        }

        public void Apply() => _settings.Value?.Apply();

        void Start() { if (_applyOnStart) Apply(); }
    }
}