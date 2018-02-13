using System;
using UnityEngine;
using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(ApplicationWrapper))]
    public class ApplicationWrapperEditor : WrapperEditor<ApplicationWrapper>
    {
        protected override void OnPlayingInspectorGUI(ApplicationWrapper wrapper)
        {
            wrapper.TargetFrameRate = EditorGUILayout.IntField("Target Frame Rate", wrapper.TargetFrameRate);
            wrapper.RunInBackground = EditorGUILayout.Toggle("Run In Background", wrapper.RunInBackground);
            wrapper.BackgroundLoadingPriority = (ThreadPriority)EditorGUILayout.EnumPopup("Background Loading Priority", wrapper.BackgroundLoadingPriority as Enum);
        }
    }
}