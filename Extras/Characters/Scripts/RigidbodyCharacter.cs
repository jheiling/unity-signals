using UnityEngine;
using Signals.Common;



namespace Signals.Extras.Characters
{
    [AddComponentMenu("Signals/Extras/Characters/RigidbodyCharacter")]
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(CapsuleCollider))]
    public class RigidbodyCharacter : MonoBehaviour
    {
#pragma warning disable
        [SerializeField] RigidbodyCharacterSettingsValueReference _settings;
#pragma warning restore
        [SerializeField] Transform _cameraPivot;
        [SerializeField] CharacterMoveSignal _moveSignal;
        [SerializeField] BoolSignal _runSignal;
        [SerializeField] BoolSignal _jumpSignal;
        [SerializeField] Vector2Signal _lookSignal;

        Transform _transform;
        Rigidbody _rigidbody;
        CapsuleCollider _collider;
        Quaternion _targetRotationX = Quaternion.identity, _targetRotationY = Quaternion.identity;
        bool _isGrounded, _isJumping;

        public RigidbodyCharacterSettingsValueReference Settings
        {
            get
            {
                return _settings;
            }
        }

        public Transform CameraPivot
        {
            get
            {
                return _cameraPivot;
            }

            set
            {
                _cameraPivot = value;
            }
        }

        public CharacterMoveSignal MoveSignal
        {
            get
            {
                return _moveSignal;
            }

            set
            {
                _moveSignal = value;
            }
        }

        public BoolSignal RunSignal
        {
            get
            {
                return _runSignal;
            }

            set
            {
                _runSignal = value;
            }
        }

        public BoolSignal JumpSignal
        {
            get
            {
                return _jumpSignal;
            }

            set
            {
                _jumpSignal = value;
            }
        }

        public Vector2Signal LookSignal
        {
            get
            {
                return _lookSignal;
            }

            set
            {
                _lookSignal = value;
            }
        }

        void Awake()
        {
            _transform = transform;
            _rigidbody = GetComponent<Rigidbody>();
            _collider = GetComponent<CapsuleCollider>();
        }

        void Update()
        {
            if (_settings.Value != null && !Mathf.Approximately(Time.timeScale, 0f))
            {
                var oldRotationY = _transform.eulerAngles.y;
                Look();
                Turn(oldRotationY);
            }
        }

        void Look()
        {
            if (_lookSignal)
            {
                _targetRotationX *= Quaternion.Euler(_lookSignal.Value.x, 0f, 0f);
                _targetRotationY *= Quaternion.Euler(0f, _lookSignal.Value.y, 0f);

                ClampRotationX();

                var t = _settings.Value.SmoothLookTime * Time.deltaTime;
                if (_cameraPivot) _cameraPivot.localRotation = Quaternion.Slerp(_cameraPivot.localRotation, _targetRotationX, t);
                _transform.localRotation = Quaternion.Slerp(_transform.localRotation, _targetRotationY, t);
            }
        }

        void ClampRotationX()
        {
            _targetRotationX.x /= _targetRotationX.w;
            _targetRotationX.y /= _targetRotationX.w;
            _targetRotationX.z /= _targetRotationX.w;
            _targetRotationX.w = 1f;
            _targetRotationX.x = Mathf.Tan(.5f * Mathf.Deg2Rad * 
                Mathf.Clamp(2f * Mathf.Rad2Deg * Mathf.Atan(_targetRotationX.x), _settings.Value.MinimumLookX, _settings.Value.MaximumLookX));
        }

        void Turn(float oldRotationY)
        {
            if (_isGrounded || _settings.Value.AirControl)
            {
                _rigidbody.velocity = Quaternion.AngleAxis(_transform.eulerAngles.y - oldRotationY, Vector3.up) * _rigidbody.velocity;
            }
        }

        void FixedUpdate()
        {
            if (_settings.Value != null)
            {
                var wasGrounded = _isGrounded;
                RaycastHit hit;

                if (Physics.SphereCast(_transform.position, _collider.radius * (1f - _settings.Value.ShellOffset), Vector3.down, out hit,
                    _collider.height * .5f - _collider.radius + _settings.Value.GroundCheckDistance))
                {
                    _isGrounded = true;
                    Move(hit.normal);
                    Jump(wasGrounded);
                }
                else
                {
                    _isGrounded = false;
                    if (_settings.Value.AirControl) Move(Vector3.up);
                    _rigidbody.drag = _settings.Value.AirDrag;
                    StickToGround(wasGrounded, ref hit);
                }
            }
        }

        void Move(Vector3 groundNormal)
        {
            if (_moveSignal)
            {
                var moveX = _moveSignal.Value.x;
                var moveZ = _moveSignal.Value.y;

                if (!Mathf.Approximately(moveX, 0f) || !Mathf.Approximately(moveZ, 0f))
                {
                    moveX *= _settings.Value.StrafeForce;
                    moveZ *= moveZ > 0 ? _settings.Value.ForwardForce : _settings.Value.BackwardForce;

                    if (_runSignal != null && _runSignal.Value)
                    {
                        moveX *= _settings.Value.RunMultiplier;
                        moveZ *= _settings.Value.RunMultiplier;
                    }

                    var move = Vector3.ProjectOnPlane(_cameraPivot.forward * moveZ + _cameraPivot.right * moveX, groundNormal);

                    if (_rigidbody.velocity.sqrMagnitude < move.sqrMagnitude)
                        _rigidbody.AddForce(move * _settings.Value.SlopeModifier.Evaluate(Vector3.Angle(groundNormal, Vector3.up)), ForceMode.Impulse);
                }
            }
        }

        void Jump(bool wasGrounded)
        {
            if (_jumpSignal != null && _jumpSignal.Value)
            {
                _isJumping = true;
                _rigidbody.drag = _settings.Value.AirDrag;
                _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);
                _rigidbody.AddForce(new Vector3(0f, _settings.Value.JumpForce), ForceMode.Impulse);
            }
            else
            {
                if (!wasGrounded) _isJumping = false;
                _rigidbody.drag = _settings.Value.GroundDrag;
            }
        }

        void StickToGround(bool wasGrounded, ref RaycastHit hit)
        {
            if (wasGrounded && !_isJumping &&
                Physics.SphereCast(_transform.position, _collider.radius * (1f - _settings.Value.ShellOffset), Vector3.down, out hit,
                    _collider.height * .5f - _collider.radius + _settings.Value.StickToGroundDistance) &&
                Mathf.Abs(Vector3.Angle(hit.normal, Vector3.up)) < 85f)
                _rigidbody.velocity = Vector3.ProjectOnPlane(_rigidbody.velocity, hit.normal);
        }
    }
}