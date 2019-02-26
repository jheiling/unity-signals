using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    /// <summary>Signal Listener for an empty <see cref="Signal"/>.</summary>
    [AddComponentMenu("Signals/SignalListener")]
    public class SignalListener : MonoBehaviour
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
#if UNITY_EDITOR
        [SerializeField] [Multiline] string _description;
#endif
        [SerializeField] Signal _signal;
        [SerializeField] UnityEvent _onUpdated;
        [SerializeField] bool _invokeImmediately;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        /// <summary>The <see cref="Signal"/>.</summary>
        public Signal Signal
        {
            get => _signal;
            set
            {
                if (enabled) RemoveListenerFromSignal();
                _signal = value;
                if (enabled) AddListenerToSignal();
            }
        }

        /// <summary>If true the listeners will also be invoked when the <see cref="SignalListener"/> is enabled or <see cref="Signal"/> is set.</summary>
        public bool InvokeImmediately
        {
            get => _invokeImmediately;
            set => _invokeImmediately = value;
        }

        /// <summary>Adds a listener.</summary>
        public void AddListener(UnityAction listener) => _onUpdated.AddListener(listener);

        /// <summary>Removes a listener.</summary>
        public void RemoveListener(UnityAction listener) => _onUpdated.RemoveListener(listener);

        protected virtual void OnEnable() => AddListenerToSignal();
        protected virtual void OnDisable() => RemoveListenerFromSignal();

        void AddListenerToSignal()
        {
            if (_signal != null)
            {
                _signal.AddListener(_onUpdated.Invoke);
                if (_invokeImmediately) _onUpdated.Invoke();
            }
        }

        void RemoveListenerFromSignal() { if (_signal != null) _signal.RemoveListener(_onUpdated.Invoke); }
    }



    /// <summary>Abstract base class for SignalListeners.</summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="Signal.OnUpdated"/> event.</typeparam>
    /// <typeparam name="ST">The type of the Signal.</typeparam>
    public abstract class SignalListener<T, ET, ST> : MonoBehaviour 
        where ET : UnityEvent<T>, new() 
        where ST : ISignal<T, ET>
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
#if UNITY_EDITOR
        [SerializeField] [Multiline] string _description;
#endif
        [SerializeField] ST _signal;
        [SerializeField] ET _onUpdated;
        [SerializeField] bool _invokeImmediately;
#pragma warning restore 649, IDE0044 // Add readonly modifier

        /// <summary>The <see cref="Signal"/>.</summary>
        public ST Signal
        {
            get => _signal;
            set
            {
                if (enabled) RemoveListenerFromSignal();
                _signal = value;
                if (enabled) AddListenerToSignal();
            }
        }

        /// <summary>If true the listeners will also be invoked when the <see cref="SignalListener"/> is enabled or <see cref="Signal"/> is set.</summary>
        public bool InvokeImmediately
        {
            get => _invokeImmediately;
            set => _invokeImmediately = value;
        }

        /// <summary>Adds a listener.</summary>
        public void AddListener(UnityAction<T> listener) => _onUpdated.AddListener(listener);

        /// <summary>Removes a listener.</summary>
        public void RemoveListener(UnityAction<T> listener) => _onUpdated.RemoveListener(listener);

        protected virtual void OnEnable() => AddListenerToSignal();
        protected virtual void OnDisable() => RemoveListenerFromSignal();

        void AddListenerToSignal()
        {
            if (_signal != null)
            {
                _signal.AddListener(_onUpdated.Invoke);
                if (_invokeImmediately) _onUpdated.Invoke(_signal.Value);
            }
        }

        void RemoveListenerFromSignal() { if (_signal != null) _signal.RemoveListener(_onUpdated.Invoke); }
    }
}