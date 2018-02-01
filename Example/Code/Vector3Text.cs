using UnityEngine;
using UnityEngine.UI;



namespace Signals.Example
{
    [AddComponentMenu("Signals/Example/Vector3Text")]
    [RequireComponent(typeof(Text))]
    public class Vector3Text : MonoBehaviour
    {
        Text _text;

        void Awake()
        {
            _text = GetComponent<Text>();
        }

        public void SetText(Vector3 value)
        {
            _text.text = value.ToString();
        }
    }
}