using System;
using UnityEngine;

namespace Signals.Extras.Characters
{
    [Serializable]
    public class RigidbodyCharacterSettings
    {
        [SerializeField] float _forwardForce = 40f;
        [SerializeField] float _backwardForce = 20f;
        [SerializeField] float _strafeForce = 20f;
        [SerializeField] float _runMultiplier = 2f;
        [SerializeField] AnimationCurve _slopeModifier = new(new Keyframe(-90.0f, 1.0f), new Keyframe(0.0f, 1.0f), new Keyframe(90.0f, 0.0f));
        [SerializeField] float _jumpForce = 400f;
        [SerializeField] bool _airControl;
        [SerializeField] float _groundDrag = 5f;
        [SerializeField] float _airDrag;
        [SerializeField] float _minimumLookX = -45f;
        [SerializeField] float _maximumLookX = 90f;
        [SerializeField] float _smoothLookTime = 18f;
        [SerializeField] float _groundCheckDistance = .1f;
        [SerializeField] float _stickToGroundDistance = .6f;
        [SerializeField] float _shellOffset = .1f;

        public float ForwardForce
        {
            get => _forwardForce;
            set => _forwardForce = value;
        }

        public float BackwardForce
        {
            get => _backwardForce;
            set => _backwardForce = value;
        }

        public float StrafeForce
        {
            get => _strafeForce;
            set => _strafeForce = value;
        }

        public float RunMultiplier
        {
            get => _runMultiplier;
            set => _runMultiplier = value;
        }

        public AnimationCurve SlopeModifier
        {
            get => _slopeModifier;
            set => _slopeModifier = value;
        }

        public float JumpForce
        {
            get => _jumpForce;
            set => _jumpForce = value;
        }

        public bool AirControl
        {
            get => _airControl;
            set => _airControl = value;
        }

        public float GroundDrag
        {
            get => _groundDrag;
            set => _groundDrag = value;
        }

        public float AirDrag
        {
            get => _airDrag;
            set => _airDrag = value;
        }

        public float MinimumLookX
        {
            get => _minimumLookX;
            set => _minimumLookX = value;
        }

        public float MaximumLookX
        {
            get => _maximumLookX;
            set => _maximumLookX = value;
        }

        public float SmoothLookTime
        {
            get => _smoothLookTime;
            set => _smoothLookTime = value;
        }

        public float GroundCheckDistance
        {
            get => _groundCheckDistance;
            set => _groundCheckDistance = value;
        }

        public float StickToGroundDistance
        {
            get => _stickToGroundDistance;
            set => _stickToGroundDistance = value;
        }

        public float ShellOffset
        {
            get => _shellOffset;
            set => _shellOffset = value;
        }
    }
}