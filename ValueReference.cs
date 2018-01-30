using UnityEngine.Events;



namespace Signals
{
    public abstract class ValueReference<T, ET, ST> where ET : UnityEvent<T>, new() where ST : Signal<T, ET>
    {
        public bool UseLocalValue;
        public ST Signal;
        public T LocalValue;

        public ValueReference() { }

        public ValueReference(T localValue)
        {
            LocalValue = localValue;
        }

        public T Value
        {
            get
            {
                return UseLocalValue ? LocalValue : Signal;
            }

            set
            {

                if (UseLocalValue) LocalValue = value;
                else Signal.Value = value;
            }
        }

        public static implicit operator T(ValueReference<T, ET, ST> reference)
        {
            return reference.Value;
        }
    }
}