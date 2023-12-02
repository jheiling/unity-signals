using UnityEngine;
using Signals.Extras.Characters;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(ExamplePlayerCharacterInput))]
    public class ExamplePlayerCharacterInput : TopDownPlayerCharacterInput
    {
        [SerializeField] Signal<string> _lookingAtSignal;

        protected override void OnMouseOverUI() => _lookingAtSignal.Value = "";

#pragma warning disable UNT0006 // Incorrect message signature
        protected override void OnMouseOver(ref RaycastHit target)
#pragma warning restore UNT0006 // Incorrect message signature
        {
            var name = target.transform.GetComponent<Name>();
            _lookingAtSignal.Value = name ? name : "";
        }
    }
}