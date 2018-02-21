using UnityEngine;



namespace Signals.Examples
{
    [CreateAssetMenu(menuName = "Signals/Examples/Logger")]
    public class Logger : ScriptableObject
    {
        public void LogMovementInput(Vector3 position)
        {
            Debug.Log("MovementInput: " + position.ToString());
        }

        public void LogUnderMousePointer(string name)
        {
            Debug.Log("UnderMousePointer: " + name);
        }
    }
}