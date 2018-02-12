namespace Signals.Utils.Engine
{
    public interface ISettings
    {
        void SetToCurrent();
        void Apply();
    }
}