using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    public abstract class SignalListener<T, ET, ST> : MonoBehaviour where ET : UnityEvent<T>, new() where ST : Signal<T, ET>
    {
#if UNITY_EDITOR
        [Multiline] public string Description = "";
#endif
        [SerializeField] ST _signal;
        [SerializeField] ET _onChanged;

        public ST Signal
        {
            get
            {
                return _signal;
            }
            set
            {
                if (_signal) _signal.RemoveListener(_onChanged.Invoke);
                if (value) value.AddListener(_onChanged.Invoke);
                _signal = value;
            }
        }

        void OnEnable()
        {
            if (_onChanged == null) _onChanged = new ET();
            if (_signal) _signal.AddListener(_onChanged.Invoke);
        }

        void OnDisable()
        {
            if (_signal) _signal.RemoveListener(_onChanged.Invoke);
        }
    }
}