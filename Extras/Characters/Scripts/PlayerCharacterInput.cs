using UnityEngine;
using Signals.Common;

namespace Signals.Extras.Characters
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Characters) + "/" + nameof(PlayerCharacterInput))]
    public class PlayerCharacterInput : MonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] PlayerCharacterInputSettingsValueReference _settings;
#pragma warning restore 649
        [SerializeField] CharacterMoveSignal _moveSignal;
        [SerializeField] BoolSignal _runSignal;
        [SerializeField] BoolSignal _jumpSignal;
        [SerializeField] Vector2Signal _lookSignal;

        public PlayerCharacterInputSettings Settings => _settings;

        public CharacterMoveSignal MoveSignal
        {
            get => _moveSignal;
            set => _moveSignal = value;
        }

        public BoolSignal RunSignal
        {
            get => _runSignal;
            set => _runSignal = value;
        }

        public BoolSignal JumpSignal
        {
            get => _jumpSignal;
            set => _jumpSignal = value;
        }

        public Vector2Signal LookSignal
        {
            get => _lookSignal;
            set => _lookSignal = value;
        }

        void OnEnable() => LockCursor();
        void OnDisable() => UnlockCursor();

        void Update()
        {
            if (_settings.Value != null)
            {
                if (_moveSignal) _moveSignal.Value = new Vector2(Input.GetAxis(_settings.Value.MoveXAxis), Input.GetAxis(_settings.Value.MoveZAxis));
                if (_runSignal != null) _runSignal.Value = Input.GetButton(_settings.Value.RunButton);
                if (_jumpSignal != null) _jumpSignal.Value = Input.GetButton(_settings.Value.JumpButton);
                if (_lookSignal)
                    _lookSignal.Value = new Vector2(-Input.GetAxis(_settings.Value.LookXAxis) * _settings.Value.LookSensitivity,
                        Input.GetAxis(_settings.Value.LookYAxis) * _settings.Value.LookSensitivity);
            }

            if (Application.isFocused) LockCursor();
            else UnlockCursor();
        }

        void LockCursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void UnlockCursor()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}