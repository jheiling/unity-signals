using System;
using UnityEngine;

namespace Signals.Extras.Characters
{
    [Serializable]
    public class PlayerCharacterInputSettings
    {
        [SerializeField] string _moveXAxis = "Horizontal";
        [SerializeField] string _moveZAxis = "Vertical";
        [SerializeField] string _runButton = "Run";
        [SerializeField] string _jumpButton = "Jump";
        [SerializeField] string _lookXAxis = "Mouse Y";
        [SerializeField] string _lookYAxis = "Mouse X";
        [SerializeField] float _lookSensitivity = 2f;

        public string MoveXAxis
        {
            get => _moveXAxis;
            set => _moveXAxis = value;
        }

        public string MoveZAxis
        {
            get => _moveZAxis;
            set => _moveZAxis = value;
        }

        public string RunButton
        {
            get => _runButton;
            set => _runButton = value;
        }

        public string JumpButton
        {
            get => _jumpButton;
            set => _jumpButton = value;
        }

        public string LookXAxis
        {
            get => _lookXAxis;
            set => _lookXAxis = value;
        }

        public string LookYAxis
        {
            get => _lookYAxis;
            set => _lookYAxis = value;
        }

        public float LookSensitivity
        {
            get => _lookSensitivity;
            set => _lookSensitivity = value;
        }
    }
}