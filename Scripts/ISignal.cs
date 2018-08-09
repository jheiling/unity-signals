using UnityEngine.Events;



namespace Signals
{
    /// <summary>
    /// The Signal interface.
    /// </summary>
    public interface ISignal
    {
        UnityEvent OnTriggered { get; }

        void Trigger();
    }



    /// <summary>
    /// The Signal interface.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="OnChanged"/> event.</typeparam>
    public interface ISignal<T, ET> 
        where ET : UnityEvent<T>, new()
    {
        /// <summary>
        /// The current value of the Signal. 
        /// Setting the value triggers the <see cref="OnChanged"/> event. 
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// The event invoked when a <see cref="Value"/> is assigned to the Signal.
        /// </summary>
        ET OnChanged { get; }

        /// <summary>
        /// Triggers the <see cref="OnChanged"/> event with the current value.
        /// </summary>
        void ForceChange();
    }
}