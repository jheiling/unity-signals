using UnityEngine;
using UnityEditor;



namespace Signals.Utils.Engine
{
    [CustomEditor(typeof(PhysicsWrapper))]
    public class PhysicsWrapperEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            if (Application.isPlaying)
            {
                var wrapper = target as PhysicsWrapper;
                wrapper.Gravity = EditorGUILayout.Vector3Field("Gravity", wrapper.Gravity);
                wrapper.BounceThreshold = EditorGUILayout.FloatField("Bounce Threshold", wrapper.BounceThreshold);
                wrapper.SleepThreshold = EditorGUILayout.FloatField("Sleep Threshold", wrapper.SleepThreshold);
                wrapper.DefaultContactOffset = EditorGUILayout.FloatField("Default Contact Offset", wrapper.DefaultContactOffset);
                wrapper.DefaultSolverIterations = EditorGUILayout.IntField("Default Solver Iterations", wrapper.DefaultSolverIterations);
                wrapper.DefaultSolverVelocityIterations = EditorGUILayout.IntField("Default Solver Velocity Iterations", wrapper.DefaultSolverVelocityIterations);
                wrapper.QueriesHitBackfaces = EditorGUILayout.Toggle("Queries Hit Backfaces", wrapper.QueriesHitBackfaces);
                wrapper.QueriesHitTriggers = EditorGUILayout.Toggle("Queries Hit Triggers", wrapper.QueriesHitTriggers);
                wrapper.AutoSimulation = EditorGUILayout.Toggle("Auto Simulation", wrapper.AutoSimulation);
                wrapper.AutoSyncTransforms = EditorGUILayout.Toggle("Auto Sync Transforms", wrapper.AutoSyncTransforms);
                wrapper.InterCollisionDistance = EditorGUILayout.FloatField("Inter Collision Distance", wrapper.InterCollisionDistance);
                wrapper.InterCollisionStiffness = EditorGUILayout.FloatField("Inter Collision Stiffness", wrapper.InterCollisionStiffness);
            }
        }

        public override bool RequiresConstantRepaint()
        {
            return true;
        }
    }
}