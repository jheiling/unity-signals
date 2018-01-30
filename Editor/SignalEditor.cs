using UnityEngine;
using UnityEngine.Events;
using UnityEditor;



namespace Signals
{
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

        protected virtual void ValueField(Signal<T, ET> signal)
        {
            GUILayout.Label(signal.Value.ToString());
        }
    }
}