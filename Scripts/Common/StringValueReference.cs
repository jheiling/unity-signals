using System;



namespace Signals.Common
{
    [Serializable]
    public class StringValueReference : ValueReference<string, StringEvent, StringSignal>
    {
        public StringValueReference() { }
        public StringValueReference(string localValue) : base(localValue) { }
    }
}