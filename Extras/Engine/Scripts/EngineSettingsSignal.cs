namespace Signals.Extras.Engine
{
    public abstract class EngineSettingsSignal<T> : Signal<T>, IEngineSettings 
        where T : IEngineSettings, new() 
    {
        public void SetToCurrent()
        {
            Value ??= new T();
            Value.SetToCurrent();
        }

        public void Apply() => Value?.Apply();
    }
}
