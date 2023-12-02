using UnityEngine;
using UnityEngine.EventSystems;

namespace Signals.Extras.Characters
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Characters) + "/" + nameof(TopDownPlayerCharacterInput))]
    public class TopDownPlayerCharacterInput : MonoBehaviour
    {
        [SerializeField] Signal<Vector3> _destinationSignal;

        public Signal<Vector3> DestinationSignal
        {
            get => _destinationSignal;
            set => _destinationSignal = value;
        }

        void Update()
        {
            if (EventSystem.current && EventSystem.current.IsPointerOverGameObject())
            {
                OnMouseOverUI();
            }
            else
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit target, Mathf.Infinity))
                {
                    OnMouseOver(ref target);
                    if (Input.GetMouseButton(0)) OnMouseButtonDown(ref target);
                }
            }
        }

        protected virtual void OnMouseOverUI() { }

#pragma warning disable UNT0006 // Incorrect message signature
        protected virtual void OnMouseOver(ref RaycastHit target) { }
#pragma warning restore UNT0006 // Incorrect message signature

        protected virtual void OnMouseButtonDown(ref RaycastHit target)
        {
            if(_destinationSignal) _destinationSignal.Value = target.point;
        }
    }
}