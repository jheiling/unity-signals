using System;
using UnityEngine;



namespace Signals.Extras.Characters
{
    [Serializable]
    public class RigidbodyCharacterSettings
    {
        [SerializeField] float _forwardSpeed = 8f;
        [SerializeField] float _backwardSpeed = 4f;
        [SerializeField] float _strafeSpeed = 4f;
        [SerializeField] float _runMultiplier = 2f;
        [SerializeField] AnimationCurve _slopeModifier = new AnimationCurve(new Keyframe(-90.0f, 1.0f), new Keyframe(0.0f, 1.0f), new Keyframe(90.0f, 0.0f));
        [SerializeField] float _jumpForce = 50f;
        [SerializeField] bool _airControl;
        [SerializeField] float _groundDrag = 5f;
        [SerializeField] float _airDrag;
        [SerializeField] float _minimumLookX = -45f;
        [SerializeField] float _maximumLookX = 90f;
        [SerializeField] float _smoothLookTime = 18f;
        [SerializeField] float _groundCheckDistance = .1f;
        [SerializeField] float _stickToGroundDistance = .6f;
        [SerializeField] float _shellOffset = .1f;

        public float ForwardSpeed
        {
            get
            {
                return _forwardSpeed;
            }

            set
            {
                _forwardSpeed = value;
            }
        }

        public float BackwardSpeed
        {
            get
            {
                return _backwardSpeed;
            }

            set
            {
                _backwardSpeed = value;
            }
        }

        public float StrafeSpeed
        {
            get
            {
                return _strafeSpeed;
            }

            set
            {
                _strafeSpeed = value;
            }
        }

        public float RunMultiplier
        {
            get
            {
                return _runMultiplier;
            }

            set
            {
                _runMultiplier = value;
            }
        }

        public AnimationCurve SlopeModifier
        {
            get
            {
                return _slopeModifier;
            }

            set
            {
                _slopeModifier = value;
            }
        }

        public float JumpForce
        {
            get
            {
                return _jumpForce;
            }

            set
            {
                _jumpForce = value;
            }
        }

        public bool AirControl
        {
            get
            {
                return _airControl;
            }

            set
            {
                _airControl = value;
            }
        }

        public float GroundDrag
        {
            get
            {
                return _groundDrag;
            }

            set
            {
                _groundDrag = value;
            }
        }

        public float AirDrag
        {
            get
            {
                return _airDrag;
            }

            set
            {
                _airDrag = value;
            }
        }

        public float MinimumLookX
        {
            get
            {
                return _minimumLookX;
            }

            set
            {
                _minimumLookX = value;
            }
        }

        public float MaximumLookX
        {
            get
            {
                return _maximumLookX;
            }

            set
            {
                _maximumLookX = value;
            }
        }

        public float SmoothLookTime
        {
            get
            {
                return _smoothLookTime;
            }

            set
            {
                _smoothLookTime = value;
            }
        }

        public float GroundCheckDistance
        {
            get
            {
                return _groundCheckDistance;
            }

            set
            {
                _groundCheckDistance = value;
            }
        }

        public float StickToGroundDistance
        {
            get
            {
                return _stickToGroundDistance;
            }

            set
            {
                _stickToGroundDistance = value;
            }
        }

        public float ShellOffset
        {
            get
            {
                return _shellOffset;
            }

            set
            {
                _shellOffset = value;
            }
        }
    }
}