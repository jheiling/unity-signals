using UnityEngine;
using UnityEngine.AI;



namespace Signals.Example
{
    [AddComponentMenu("Signals/Example/PlayerMovement")]
    [RequireComponent(typeof(NavMeshAgent))]
    public class PlayerMovement : MonoBehaviour
    {
        public void MoveTo(Vector3 position)
        {
            GetComponent<NavMeshAgent>().destination = position;
        }
    }
}