using UnityEngine;
using UnityEngine.Events;



namespace Signals
{
    public interface ISignal<T>
    {
        T Value { get; set; }
        void AddListener(UnityAction<T> call);
        void RemoveListener(UnityAction<T> call);
        void RemoveAllListeners();
    }



    public abstract class Signal<T, ET> : ScriptableObject, ISignal<T> where ET : UnityEvent<T>, new()
    {
#if UNITY_EDITOR
        [Multiline] public string Description = "";
        [SerializeField] bool _serializeChanges;
#endif
        [SerializeField] T _initialValue;
        T _value;
        [SerializeField] ET _onChanged;

        public T InitialValue
        {
            get
            {
                return _initialValue;
            }
        }

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (HasChanged(value))
                {
#if UNITY_EDITOR
                    if (_serializeChanges) _initialValue = value;
#endif
                    _value = value;
                    _onChanged.Invoke(value);
                }
            }
        }

        protected virtual bool HasChanged(T value)
        {
            return true;
        }

        void OnEnable()
        {
            _value = _initialValue;
            if (_onChanged == null) _onChanged = new ET();
        }

        public void AddListener(UnityAction<T> call)
        {
            _onChanged.AddListener(call);
        }

        public void RemoveListener(UnityAction<T> call)
        {
            _onChanged.RemoveListener(call);
        }

        public void RemoveAllListeners()
        {
            _onChanged.RemoveAllListeners();
        }
    }
}