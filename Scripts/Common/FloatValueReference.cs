using System;



namespace Signals.Common
{
    [Serializable]
    public class FloatValueReference : ValueReference<float, FloatEvent, FloatSignal>
    {
        public FloatValueReference() { }
        public FloatValueReference(float localValue) : base(localValue) { }
    }
}