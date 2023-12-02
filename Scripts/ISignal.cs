using UnityEngine.Events;

namespace Signals
{
    /// <summary>The empty Signal interface.</summary>
    public interface ISignal
    {
        /// <summary>Adds a listener.</summary>
        void AddListener(UnityAction listener);

        /// <summary>Removes a listener.</summary>
        void RemoveListener(UnityAction listener);

        /// <summary>Invokes listeners.</summary>
        void TriggerUpdate();
    }



    /// <summary>The Signal interface.</summary>
    /// <typeparam name="T">The type of the <see cref="Value"/>.</typeparam>
    public interface ISignal<T>
    {
        /// <summary>
        /// The current value of the <see cref="Signal"/>. 
        /// Setting the value invokes listeners. 
        /// </summary>
        T Value { get; set; }

        /// <summary>Adds a listener.</summary>
        void AddListener(UnityAction<T> listener);

        /// <summary>Removes a listener.</summary>
        void RemoveListener(UnityAction<T> listener);

        /// <summary>Invokes listeners with the current value.</summary>
        void TriggerUpdate();
    }
}