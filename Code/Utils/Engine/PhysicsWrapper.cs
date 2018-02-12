using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(menuName = "Signals/Utils/Engine/PhysicsWrapper")]
    public class PhysicsWrapper : ScriptableObject
    {
        public Vector3 Gravity
        {
            get
            {
                return Physics.gravity;
            }

            set
            {
                Physics.gravity = value;
            }
        }

        public float GravityY
        {
            get
            {
                return Gravity.y;
            }

            set
            {
                Gravity = new Vector3(Gravity.x, value, Gravity.z);
            }
        }

        public float BounceThreshold
        {
            get
            {
                return Physics.bounceThreshold;
            }

            set
            {
                Physics.bounceThreshold = value;
            }
        }

        public float SleepThreshold
        {
            get
            {
                return Physics.sleepThreshold;
            }

            set
            {
                Physics.sleepThreshold = value;
            }
        }

        public float DefaultContactOffset
        {
            get
            {
                return Physics.defaultContactOffset;
            }

            set
            {
                Physics.defaultContactOffset = value;
            }
        }

        public int DefaultSolverIterations
        {
            get
            {
                return Physics.defaultSolverIterations;
            }

            set
            {
                Physics.defaultSolverIterations = value;
            }
        }

        public int DefaultSolverVelocityIterations
        {
            get
            {
                return Physics.defaultSolverVelocityIterations;
            }

            set
            {
                Physics.defaultSolverVelocityIterations = value;
            }
        }

        public bool QueriesHitBackfaces
        {
            get
            {
                return Physics.queriesHitBackfaces;
            }

            set
            {
                Physics.queriesHitBackfaces = value;
            }
        }

        public bool QueriesHitTriggers
        {
            get
            {
                return Physics.queriesHitTriggers;
            }

            set
            {
                Physics.queriesHitTriggers = value;
            }
        }

        public bool AutoSimulation
        {
            get
            {
                return Physics.autoSimulation;
            }

            set
            {
                Physics.autoSimulation = value;
            }
        }

        public bool AutoSyncTransforms
        {
            get
            {
                return Physics.autoSyncTransforms;
            }

            set
            {
                Physics.autoSyncTransforms = value;
            }
        }

        public float InterCollisionDistance
        {
            get
            {
                return Physics.interCollisionDistance;
            }

            set
            {
                Physics.interCollisionDistance = value;
            }
        }

        public float InterCollisionStiffness
        {
            get
            {
                return Physics.interCollisionStiffness;
            }

            set
            {
                Physics.interCollisionStiffness = value;
            }
        }
    }
}