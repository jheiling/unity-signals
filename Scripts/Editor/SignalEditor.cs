﻿using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

namespace Signals
{
    /// <summary>Abstract base class for custom editors for classes inheriting from <see cref="Signal"/>.</summary>
    /// <typeparam name="T">The type of the <see cref="Signal.Value"/>.</typeparam>
    /// <typeparam name="ET">The type of the <see cref="Signal.OnChanged"/> event.</typeparam>
    public abstract class SignalEditor<T, ET> : Editor where ET : UnityEvent<T>, new()
    {
        static readonly GUIContent _descriptionLabel = new GUIContent("Description");
        static readonly GUIContent _onChangedLabel = new GUIContent("On Changed");
        static readonly GUIContent _serializeChangesLabel = new GUIContent("Serialize Changes");

        SerializedProperty _description;
        SerializedProperty _onChanged;
        SerializedProperty _serializeChanges;

        void OnEnable()
        {
            _description = serializedObject.FindProperty("_description");
            _onChanged = serializedObject.FindProperty("_onChanged");
            _serializeChanges = serializedObject.FindProperty("_serializeChanges");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            var signal = target as Signal<T, ET>;

            EditorGUILayout.PropertyField(_description, _descriptionLabel);

            GUILayout.BeginHorizontal();
            GUILayout.Label("Initial Value");
            var value = ValueField(signal.InitialValue);
            if (!signal.InitialValue.Equals(value)) signal.InitialValue = value;
            GUILayout.EndHorizontal();

            EditorGUILayout.PropertyField(_onChanged, _onChangedLabel);
            EditorGUILayout.Toggle("Use Validation", signal.UseValidation);
            EditorGUILayout.PropertyField(_serializeChanges, _serializeChangesLabel);

            if (Application.isPlaying)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label("Value");
                value = ValueField(signal);
                if (!signal.Value.Equals(value)) signal.Value = value;
                if(GUILayout.Button("Change to Initial Value")) signal.Value = signal.InitialValue;
                GUILayout.EndHorizontal();
            }

            serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Override this method to provide an editable field for the <see cref="Signal.InitialValue">, 
        /// and for the current <see cref="Signal.Value"/> when the application is running.
        /// </summary>
        /// <param name="value">The value to display.</param>
        /// <returns>The new value.</returns>
        protected virtual T ValueField(T value)
        {
            GUILayout.Label(value.ToString());
            return value;
        }

        public override bool RequiresConstantRepaint() => true;
    }
}