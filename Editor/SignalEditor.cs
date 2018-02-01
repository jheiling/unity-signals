using UnityEngine;
using UnityEngine.Events;
using UnityEditor;



namespace Signals
{
    /// <summary>
    /// Abstract base class for custom editors for classes inheriting from <see cref="Signal"/>.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="Signal.OnChanged"/> event.</typeparam>
    public abstract class SignalEditor<T, ET> : Editor where ET : UnityEvent<T>, new()
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (Application.isPlaying)
            {
                var signal = target as Signal<T, ET>;
                GUILayout.BeginHorizontal();
                GUILayout.Label("Value");
                ValueField(signal);
                if(GUILayout.Button("Change to Initial Value")) signal.Value = signal.InitialValue;
                GUILayout.EndHorizontal();
            }
        }

        /// <summary>
        /// Override this method to provide an editable field for the current <see cref="Signal.Value"/> when the application is running in the editor.
        /// </summary>
        /// <param name="signal">The <see cref="Signal"/>.</param>
        protected virtual void ValueField(Signal<T, ET> signal)
        {
            GUILayout.Label(signal.Value.ToString());
        }

        public override bool RequiresConstantRepaint()
        {
            return true;
        }
    }
}