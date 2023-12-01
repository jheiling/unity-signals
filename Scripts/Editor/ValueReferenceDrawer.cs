using UnityEngine;
using UnityEditor;

namespace Signals
{
    /// <summary>Abstract base class for custom drawers for classes inheriting from <see cref="ValueReference"/>.</summary>
    public abstract class ValueReferenceDrawer : PropertyDrawer
    {
        static readonly string[] _popupOptions = { "Use Signal Value", "Use Local Value" };

        static readonly GUIStyle _popupStyle = new(GUI.skin.GetStyle("PaneOptions"))
        {
            imagePosition = ImagePosition.ImageOnly
        };

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            var popupPosition = new Rect(position.x, position.y + _popupStyle.margin.top, _popupStyle.fixedWidth + _popupStyle.margin.right, position.height);
            var useLocalValue = property.FindPropertyRelative("_useLocalValue");
            useLocalValue.boolValue = EditorGUI.Popup(popupPosition, useLocalValue.boolValue ? 1 : 0, _popupOptions, _popupStyle) == 1;

            position.xMin = popupPosition.xMax;
            if (useLocalValue.boolValue) LocalValueField(position, property.FindPropertyRelative("_localValue"));
            else EditorGUI.PropertyField(position, property.FindPropertyRelative("_signal"), GUIContent.none);

            if (EditorGUI.EndChangeCheck()) property.serializedObject.ApplyModifiedProperties();

            EditorGUI.EndProperty();
        }

        /// <summary>Override this method to implement a custom inspector for the <see cref="ValueReference.LocalValue"/>.</summary>
        /// <param name="position">The field's position.</param>
        /// <param name="localValue">The SerializedProperty containing the value.</param>
        protected virtual void LocalValueField(Rect position, SerializedProperty localValue) =>
            EditorGUI.PropertyField(position, localValue, GUIContent.none, true);

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) => 
            property.FindPropertyRelative("_useLocalValue").boolValue ? GetLocalValueFieldHeight() : EditorGUIUtility.singleLineHeight;

        /// <summary>Override this if your <see cref="LocalValueField"/> is higher than one line.</summary>
        /// <returns>The <see cref="LocalValueField"/>'s height.</returns>
        protected virtual float GetLocalValueFieldHeight() => EditorGUIUtility.singleLineHeight;
    }
}