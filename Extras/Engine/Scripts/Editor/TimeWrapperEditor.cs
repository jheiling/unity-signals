using UnityEngine;
using UnityEditor;

namespace Signals.Extras.Engine
{
    [CustomEditor(typeof(TimeWrapper))]
    public class TimeWrapperEditor : WrapperEditor<TimeWrapper>
    {
        protected override void OnPlayingInspectorGUI(TimeWrapper wrapper)
        {
            wrapper.FixedDeltaTime = EditorGUILayout.FloatField(wrapper.FixedDeltaTime);
            wrapper.MaximumDeltaTime = EditorGUILayout.FloatField(wrapper.MaximumDeltaTime);
            wrapper.TimeScale = EditorGUILayout.FloatField(wrapper.TimeScale);
            wrapper.MaximumParticleDeltaTime = EditorGUILayout.FloatField(wrapper.MaximumParticleDeltaTime);
            wrapper.CaptureFramerate = EditorGUILayout.IntField(wrapper.CaptureFramerate);
        }
    }
}