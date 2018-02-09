using UnityEngine;



namespace Signals.Utils.Engine
{
    [AddComponentMenu("Signals/Utils/Engine/PhysicsSetup")]
    public class PhysicsSetup : MonoBehaviour
    {
        [SerializeField] PhysicsSettingsValueReference _settings;
        [SerializeField] bool _applyOnStart = true;

        public PhysicsSettingsValueReference Settings
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

        public void Apply()
        {
            if(_settings.Value != null) _settings.Value.Apply();
        }
    }
}