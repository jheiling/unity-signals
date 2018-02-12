using UnityEngine;
using UnityEngine.EventSystems;
using Signals.Common;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/InputSystem")]
    public class InputSystem : MonoBehaviour
    {
        public StringSignal LookingAtSignal;
        public Vector3Signal DestinationSignal;

        void Update()
        {
            if(EventSystem.current && EventSystem.current.IsPointerOverGameObject())
            {
                LookingAtSignal.Value = "";
            }
            else
            {
                RaycastHit target;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out target, Mathf.Infinity))
                {
                    var name = target.transform.GetComponent<Name>();
                    LookingAtSignal.Value = name ? name.Value : "";

                    if (Input.GetMouseButton(0)) DestinationSignal.Value = target.point;
                }
            }
        }
    }
}