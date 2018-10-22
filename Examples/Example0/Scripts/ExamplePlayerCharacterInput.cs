using UnityEngine;
using Signals.Common;
using Signals.Extras.Characters;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/ExamplePlayerCharacterInput")]
    public class ExamplePlayerCharacterInput : TopDownPlayerCharacterInput
    {
#pragma warning disable
        [SerializeField] StringSignal _lookingAtSignal;
#pragma warning restore

        protected override void OnMouseOverUI()
        {
            _lookingAtSignal.Value = "";
        }

        protected override void OnMouseOver(ref RaycastHit target)
        {
            var name = target.transform.GetComponent<Name>();
            _lookingAtSignal.Value = name ? name : "";
        }
    }
}