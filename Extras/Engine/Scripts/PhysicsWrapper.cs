using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(fileName = "Physics", menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(PhysicsWrapper))]
    public class PhysicsWrapper : ScriptableObject
    {
        public Vector3 Gravity
        {
            get => Physics.gravity;
            set => Physics.gravity = value;
        }

        public float GravityY
        {
            get => Gravity.y;
            set => Gravity = new Vector3(Gravity.x, value, Gravity.z);
        }

        public float BounceThreshold
        {
            get => Physics.bounceThreshold;
            set => Physics.bounceThreshold = value;
        }

        public float SleepThreshold
        {
            get => Physics.sleepThreshold;
            set => Physics.sleepThreshold = value;
        }

        public float DefaultContactOffset
        {
            get => Physics.defaultContactOffset;
            set => Physics.defaultContactOffset = value;
        }

        public int DefaultSolverIterations
        {
            get => Physics.defaultSolverIterations;
            set => Physics.defaultSolverIterations = value;
        }

        public int DefaultSolverVelocityIterations
        {
            get => Physics.defaultSolverVelocityIterations;
            set => Physics.defaultSolverVelocityIterations = value;
        }

        public bool QueriesHitBackfaces
        {
            get => Physics.queriesHitBackfaces;
            set => Physics.queriesHitBackfaces = value;
        }

        public bool QueriesHitTriggers
        {
            get => Physics.queriesHitTriggers;
            set => Physics.queriesHitTriggers = value;
        }

        public bool AutoSimulation
        {
            get => Physics.autoSimulation;
            set => Physics.autoSimulation = value;
        }

        public bool AutoSyncTransforms
        {
            get => Physics.autoSyncTransforms;
            set => Physics.autoSyncTransforms = value;
        }

        public float InterCollisionDistance
        {
            get => Physics.interCollisionDistance;
            set => Physics.interCollisionDistance = value;
        }

        public float InterCollisionStiffness
        {
            get => Physics.interCollisionStiffness;
            set => Physics.interCollisionStiffness = value;
        }
    }
}