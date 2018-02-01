using UnityEngine;



namespace Signals.Example
{
    [CreateAssetMenu(menuName = "Signals/Example/Logger")]
    public class Logger : ScriptableObject
    {
        public void LogMovementInput(Vector3 position)
        {
            Debug.Log("MovementInput: " + position.ToString());
        }
    }
}