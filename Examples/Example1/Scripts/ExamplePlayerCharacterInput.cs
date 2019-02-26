using UnityEngine;
using Signals.Common;
using Signals.Extras.Characters;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(ExamplePlayerCharacterInput))]
    public class ExamplePlayerCharacterInput : TopDownPlayerCharacterInput
    {
#pragma warning disable 649
        [SerializeField] StringSignal _lookingAtSignal;
#pragma warning restore 649

        protected override void OnMouseOverUI() => _lookingAtSignal.Value = "";

        protected override void OnMouseOver(ref RaycastHit target)
        {
            var name = target.transform.GetComponent<Name>();
            _lookingAtSignal.Value = name ? name : "";
        }
    }
}