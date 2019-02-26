using UnityEngine;
using UnityEngine.EventSystems;
using Signals.Common;

namespace Signals.Extras.Characters
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Characters) + "/" + nameof(TopDownPlayerCharacterInput))]
    public class TopDownPlayerCharacterInput : MonoBehaviour
    {
        [SerializeField] Vector3Signal _destinationSignal;

        public Vector3Signal DestinationSignal
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
        protected virtual void OnMouseOver(ref RaycastHit target) { }

        protected virtual void OnMouseButtonDown(ref RaycastHit target)
        {
            if(_destinationSignal) _destinationSignal.Value = target.point;
        }
    }
}