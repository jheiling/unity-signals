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
                RemoveListener();
                _signal = value;
                AddListener();
            }
        }

        public ET OnChanged
        {
            get
            {
                return _onChanged;
            }
        }

        void OnEnable()
        {
            if (_onChanged == null) _onChanged = new ET();
            AddListener();
        }

        void OnDisable()
        {
            RemoveListener();
        }

        void AddListener()
        {
            if (_signal) _signal.OnChanged.AddListener(_onChanged.Invoke);
        }

        void RemoveListener()
        {
            if (_signal) _signal.OnChanged.RemoveListener(_onChanged.Invoke);
        }
    }
}