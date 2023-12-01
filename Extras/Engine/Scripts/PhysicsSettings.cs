using System;
using UnityEngine;

namespace Signals.Extras.Engine
{
    [Serializable]
    public class PhysicsSettings : IEngineSettings
    {
        [SerializeField] Vector3 _gravity = new Vector3(0f, -9.81f, 0f);
        [SerializeField] float _bounceThreshold = 2f;
        [SerializeField] float _sleepThreshold = .005f;
        [SerializeField] float _defaultContactOffset = .01f;
        [SerializeField] int _defaultSolverIterations = 6;
        [SerializeField] int _defaultSolverVelocityIterations = 1;
        [SerializeField] bool _queriesHitBackfaces;
        [SerializeField] bool _queriesHitTriggers = true;
        [SerializeField] SimulationMode _simulationMode = SimulationMode.FixedUpdate;
        [SerializeField] bool _autoSyncTransforms = true;
        [SerializeField] float _interCollisionDistance;
        [SerializeField] float _interCollisionStiffness;

        public Vector3 Gravity
        {
            get => _gravity;
            set => _gravity = value;
        }

        public float BounceThreshold
        {
            get => _bounceThreshold;
            set => _bounceThreshold = value;
        }

        public float SleepThreshold
        {
            get => _sleepThreshold;
            set => _sleepThreshold = value;
        }

        public float DefaultContactOffset
        {
            get => _defaultContactOffset;
            set => _defaultContactOffset = value;
        }

        public int DefaultSolverIterations
        {
            get => _defaultSolverIterations;
            set => _defaultSolverIterations = value;
        }

        public int DefaultSolverVelocityIterations
        {
            get => _defaultSolverVelocityIterations;
            set => _defaultSolverVelocityIterations = value;
        }

        public bool QueriesHitBackfaces
        {
            get => _queriesHitBackfaces;
            set => _queriesHitBackfaces = value;
        }

        public bool QueriesHitTriggers
        {
            get => _queriesHitTriggers;
            set => _queriesHitTriggers = value;
        }

        public SimulationMode SimulationMode
        {
            get => _simulationMode;
            set => _simulationMode = value;
        }

        public bool AutoSyncTransforms
        {
            get => _autoSyncTransforms;
            set => _autoSyncTransforms = value;
        }

        public float InterCollisionDistance
        {
            get => _interCollisionDistance;
            set => _interCollisionDistance = value;
        }

        public float InterCollisionStiffness
        {
            get => _interCollisionStiffness;
            set => _interCollisionStiffness = value;
        }

        public void SetToCurrent()
        {
            _gravity = Physics.gravity;
            _bounceThreshold = Physics.bounceThreshold;
            _sleepThreshold = Physics.sleepThreshold;
            _defaultContactOffset = Physics.defaultContactOffset;
            _defaultSolverIterations = Physics.defaultSolverIterations;
            _defaultSolverVelocityIterations = Physics.defaultSolverVelocityIterations;
            _queriesHitBackfaces = Physics.queriesHitBackfaces;
            _queriesHitTriggers = Physics.queriesHitTriggers;
            _simulationMode = Physics.simulationMode;
            _autoSyncTransforms = Physics.autoSyncTransforms;
            _interCollisionDistance = Physics.interCollisionDistance;
            _interCollisionStiffness = Physics.interCollisionStiffness;
        }

        public void Apply()
        {
            Physics.gravity = _gravity;
            Physics.bounceThreshold = _bounceThreshold;
            Physics.sleepThreshold = _sleepThreshold;
            Physics.defaultContactOffset = _defaultContactOffset;
            Physics.defaultSolverIterations = _defaultSolverIterations;
            Physics.defaultSolverVelocityIterations = _defaultSolverVelocityIterations;
            Physics.queriesHitBackfaces = _queriesHitBackfaces;
            Physics.queriesHitTriggers = _queriesHitTriggers;
            Physics.simulationMode = _simulationMode;
            Physics.autoSyncTransforms = _autoSyncTransforms;
            Physics.interCollisionDistance = _interCollisionDistance;
            Physics.interCollisionStiffness = _interCollisionStiffness;
        }
    }
}