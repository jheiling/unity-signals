using UnityEngine;
using Signals.Common;
using Signals.Extras.Characters;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/ExamplePlayerCharacterInput")]
    public class ExamplePlayerCharacterInput : TopDownPlayerCharacterInput
    {
        [SerializeField] StringSignal _lookingAtSignal;

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