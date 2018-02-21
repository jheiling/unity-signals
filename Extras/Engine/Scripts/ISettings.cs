namespace Signals.Extras.Engine
{
    public interface ISettings
    {
        void SetToCurrent();
        void Apply();
    }
}