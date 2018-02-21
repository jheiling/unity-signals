using System;



namespace Signals.Common
{
    [Serializable]
    public class IntValueReference : ValueReference<int, IntEvent, IntSignal>
    {
        public IntValueReference() { }
        public IntValueReference(int localValue) : base(localValue) { }
    }
}
