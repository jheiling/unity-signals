using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(fileName = "Debug", menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(DebugWrapper))]
    public class DebugWrapper : ScriptableObject
    {
        public void Assert(bool condition) => Debug.Assert(condition);
        public void Break() => Debug.Break();

        public void Log(string message) => Debug.Log(message);
        public void LogWarning(string message) => Debug.LogWarning(message);
        public void LogError(string message) => Debug.LogError(message);

        public void Log(bool message) => Debug.Log(message);
        public void LogWarning(bool message) => Debug.LogWarning(message);
        public void LogError(bool message) => Debug.LogError(message);

        public void Log(char message) => Debug.Log(message);
        public void LogWarning(char message) => Debug.LogWarning(message);
        public void LogError(char message) => Debug.LogError(message);

        public void Log(float message) => Debug.Log(message);
        public void LogWarning(float message) => Debug.LogWarning(message);
        public void LogError(float message) => Debug.LogError(message);

        public void Log(int message) => Debug.Log(message);
        public void LogWarning(int message) => Debug.LogWarning(message);
        public void LogError(int message) => Debug.LogError(message);

        public void Log(Quaternion message) => Debug.Log(message);
        public void LogWarning(Quaternion message) => Debug.LogWarning(message);
        public void LogError(Quaternion message) => Debug.LogError(message);

        public void Log(Vector2 message) => Debug.Log(message);
        public void LogWarning(Vector2 message) => Debug.LogWarning(message);
        public void LogError(Vector2 message) => Debug.LogError(message);

        public void Log(Vector2Int message) => Debug.Log(message);
        public void LogWarning(Vector2Int message) => Debug.LogWarning(message);
        public void LogError(Vector2Int message) => Debug.LogError(message);

        public void Log(Vector3 message) => Debug.Log(message);
        public void LogWarning(Vector3 message) => Debug.LogWarning(message);
        public void LogError(Vector3 message) => Debug.LogError(message);

        public void Log(Vector3Int message) => Debug.Log(message);
        public void LogWarning(Vector3Int message) => Debug.LogWarning(message);
        public void LogError(Vector3Int message) => Debug.LogError(message);

        public void Log(Vector4 message) => Debug.Log(message);
        public void LogWarning(Vector4 message) => Debug.LogWarning(message);
        public void LogError(Vector4 message) => Debug.LogError(message);
    }
}