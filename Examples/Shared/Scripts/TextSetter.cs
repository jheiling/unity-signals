﻿using UnityEngine;
using UnityEngine.UI;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(TextSetter))]
    [RequireComponent(typeof(Text))]
    public class TextSetter : MonoBehaviour
    {
        public void SetText(float value) => GetComponent<Text>().text = value.ToString();
        public void SetText(Vector3 value) => GetComponent<Text>().text = value.ToString();
    }
}