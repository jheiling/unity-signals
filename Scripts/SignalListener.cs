using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    /// <summary>
    /// Abstract base class for MonoBehaviours which propagate a <see cref="Signal.OnChanged"/> event.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="Signal.OnChanged"/> event.</typeparam>
    /// <typeparam name="ST">The type of the Signal.</typeparam>
    public abstract class SignalListener<T, ET, ST> : MonoBehaviour where ET : UnityEvent<T>, new() where ST : Signal<T, ET>
    {
#if UNITY_EDITOR
#pragma warning disable
        [SerializeField] [Multiline] string _description;
#pragma warning restore
#endif
        [SerializeField] ST _signal;
        [SerializeField] ET _onChanged;
        [SerializeField] bool _invokeImmediately;

        /// <summary>
        /// The signal whose <see cref="Signal.OnChanged"/> event is propagated.
        /// </summary>
        public ST Signal
        {
            get
            {
                return _signal;
            }

            set
            {
                if (enabled) RemoveListener();
                _signal = value;
                if (enabled) AddListener();
            }
        }

        /// <summary>
        /// Invoked when the <see cref="Signal.Value"/> of the signal has changed.
        /// </summary>
        public ET OnChanged
        {
            get
            {
                return _onChanged;
            }
        }

        /// <summary>
        /// If true the OnChanged event will also be invoked when the SignalListener is enabled or <see cref="Signal"/> is set.
        /// </summary>
        public bool InvokeImmediately
        {
            get
            {
                return _invokeImmediately;
            }

            set
            {
                _invokeImmediately = value;
            }
        }

        protected virtual void Awake()
        {
            if (_onChanged == null) _onChanged = new ET();
        }

        protected virtual void OnEnable()
        {   
            AddListener();
        }

        protected virtual void OnDisable()
        {
            RemoveListener();
        }

        void AddListener()
        {
            if (_signal)
            {
                _signal.OnChanged.AddListener(_onChanged.Invoke);
                if (_invokeImmediately) _onChanged.Invoke(_signal);
            }
        }

        void RemoveListener()
        {
            if (_signal) _signal.OnChanged.RemoveListener(_onChanged.Invoke);
        }
    }
}