using UnityEngine;
using UnityEngine.Events;

namespace Signals.Extras.Engine
{
    public abstract class SettingsSignal<T, ET> : Signal<T, ET>, ISettings 
        where T : ISettings, new() 
        where ET : UnityEvent<T>, new()
    {
        public void SetToCurrent()
        {
            if (Value == null) Value = new T();
            Value.SetToCurrent();
        }

        public void Apply() { if (Value != null) Value.Apply(); }
    }
}
