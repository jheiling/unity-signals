using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    /// <summary>
    /// Signal Listener for a basic Signal.
    /// </summary>
    [AddComponentMenu("Signals/SignalListener")]
    public class SignalListener : MonoBehaviour
    {
#if UNITY_EDITOR
#pragma warning disable
        [SerializeField] [Multiline] string _description;
#pragma warning restore
#endif
        [SerializeField] Signal _signal;
        [SerializeField] UnityEvent _onTriggered;
        [SerializeField] bool _invokeImmediately;

        protected virtual void Awake()
        {
            if (_onTriggered == null) _onTriggered = new UnityEvent();
        }

        protected virtual void OnEnable()
        {
            AddListener();
        }

        protected virtual void OnDisable()
        {
            RemoveListener();
        }

        /// <summary>
        /// The signal whose <see cref="Signal.OnTriggered"/> event is propagated.
        /// </summary>
        public Signal Signal
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
        /// Invoked when <see cref="Signal.Trigger"/> of the <see cref="Signal"/> is called.
        /// </summary>
        public UnityEvent OnTriggered
        {
            get
            {
                return _onTriggered;
            }
        }

        /// <summary>
        /// If true the <see cref="OnChanged"/> event will also be invoked when the SignalListener is enabled or <see cref="Signal"/> is set.
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

        void AddListener()
        {
            if (!_signal.Equals(null))
            {
                _signal.OnTriggered.AddListener(_onTriggered.Invoke);
                if (_invokeImmediately) _onTriggered.Invoke();
            }
        }

        void RemoveListener()
        {
            if (!_signal.Equals(null)) _signal.OnTriggered.RemoveListener(_onTriggered.Invoke);
        }
    }



    /// <summary>
    /// Abstract base class for MonoBehaviours which propagate a <see cref="Signal.OnChanged"/> event.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="Signal.OnChanged"/> event.</typeparam>
    /// <typeparam name="ST">The type of the Signal.</typeparam>
    public abstract class SignalListener<T, ET, ST> : MonoBehaviour 
        where ET : UnityEvent<T>, new() 
        where ST : ISignal<T, ET>
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
        /// If true the <see cref="OnChanged"/> event will also be invoked when the SignalListener is enabled or <see cref="Signal"/> is set.
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
            if (!_signal.Equals(null))
            {
                _signal.OnChanged.AddListener(_onChanged.Invoke);
                if (_invokeImmediately) _onChanged.Invoke(_signal.Value);
            }
        }

        void RemoveListener()
        {
            if (!_signal.Equals(null)) _signal.OnChanged.RemoveListener(_onChanged.Invoke);
        }
    }
}