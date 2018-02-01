using UnityEngine;
using UnityEngine.UI;



namespace Signals.Example
{
    [AddComponentMenu("Signals/Example/Vector3Text")]
    [RequireComponent(typeof(Text))]
    public class Vector3Text : MonoBehaviour
    {
        public void SetText(Vector3 value)
        {
            GetComponent<Text>().text = value.ToString();
        }
    }
}