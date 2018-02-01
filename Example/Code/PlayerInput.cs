using UnityEngine;
using UnityEngine.EventSystems;
using Signals.Common;



namespace Signals.Example
{
    [AddComponentMenu("Signals/Example/PlayerInput")]
    public class PlayerInput : MonoBehaviour
    {
        public StringSignal UnderMousePointerSignal;
        public Vector3Signal MovementInputSignal;

        void Update()
        {
            if(EventSystem.current && EventSystem.current.IsPointerOverGameObject())
            {
                UnderMousePointerSignal.Value = "";
            }
            else
            {
                RaycastHit target;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out target, Mathf.Infinity))
                {
                    var name = target.transform.GetComponent<Name>();
                    UnderMousePointerSignal.Value = target.transform.GetComponent<Name>() ? name.Value : "";

                    if (Input.GetMouseButtonDown(0)) MovementInputSignal.Value = target.point;
                }
            }
        }
    }
}