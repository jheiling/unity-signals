using UnityEngine;
using Signals.Common;

namespace Signals.Extras.Characters
{
    [CreateAssetMenu(menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Characters) + "/" + nameof(CharacterMoveSignal))]
    public class CharacterMoveSignal : Vector2Signal
    {
        protected override void ProcessValue(ref Vector2 value) { if (value.sqrMagnitude > 1f) value.Normalize(); }
    }
}