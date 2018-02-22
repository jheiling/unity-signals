using UnityEngine;
using UnityEngine.EventSystems;
using Signals.Common;



namespace Signals.Extras.Characters
{
    [AddComponentMenu("Signals/Extras/Characters/TopDownPlayerCharacterInput")]
    public class TopDownPlayerCharacterInput : MonoBehaviour
    {
        [SerializeField] Vector3Signal _destinationSignal;

        public Vector3Signal DestinationSignal
        {
            get
            {
                return _destinationSignal;
            }

            set
            {
                _destinationSignal = value;
            }
        }

        void Update()
        {
            if (EventSystem.current && EventSystem.current.IsPointerOverGameObject())
            {
                OnMouseOverUI();
            }
            else
            {
                RaycastHit target;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out target, Mathf.Infinity))
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