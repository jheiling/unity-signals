using UnityEngine;
using UnityEditor;



namespace Signals
{
    /// <summary>
    /// Abstract base class for custom drawers for classes inheriting from <see cref="ValueReference"/>.
    /// </summary>
    public abstract class ValueReferenceDrawer : PropertyDrawer
    {
        readonly static string[] popupOptions = { "Use Signal Value", "Use Local Value" };
        static GUIStyle popupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (popupStyle == null)
            {
                popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                popupStyle.imagePosition = ImagePosition.ImageOnly;
            }

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            var useLocalValue = property.FindPropertyRelative("UseLocalValue");
            var signal = property.FindPropertyRelative("Signal");
            var localValue = property.FindPropertyRelative("LocalValue");

            var buttonRect = new Rect(position);
            buttonRect.yMin += popupStyle.margin.top;
            buttonRect.width = popupStyle.fixedWidth + popupStyle.margin.right;
            position.xMin = buttonRect.xMax;

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            useLocalValue.boolValue = EditorGUI.Popup(buttonRect, useLocalValue.boolValue ? 0 : 1, popupOptions, popupStyle) == 1;

            EditorGUI.PropertyField(position, useLocalValue.boolValue ? localValue : signal, GUIContent.none);

            if (EditorGUI.EndChangeCheck()) property.serializedObject.ApplyModifiedProperties();

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}