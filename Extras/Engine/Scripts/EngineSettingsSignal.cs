using UnityEngine.Events;

namespace Signals.Extras.Engine
{
    public abstract class EngineSettingsSignal<T, ET> : Signal<T, ET>, IEngineSettings 
        where T : IEngineSettings, new() 
        where ET : UnityEvent<T>, new()
    {
        public void SetToCurrent()
        {
            if (Value == null) Value = new T();
            Value.SetToCurrent();
        }

        public void Apply() => Value?.Apply();
    }
}
