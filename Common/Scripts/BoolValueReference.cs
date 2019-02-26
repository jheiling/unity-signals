using System;

namespace Signals.Common
{
    [Serializable]
    public class BoolValueReference : ValueReference<bool, BoolEvent, BoolSignal>
    {
        public BoolValueReference() { }
        public BoolValueReference(bool localValue) : base(localValue) { }
    }
}
