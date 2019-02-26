using System;

namespace Signals.Common
{
    [Serializable]
    public class CharValueReference : ValueReference<char, CharEvent, CharSignal>
    {
        public CharValueReference() { }
        public CharValueReference(char localValue) : base(localValue) { }
    }
}
