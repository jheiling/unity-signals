using System;
using UnityEngine;
using UnityEngine.Events;

namespace Signals.Common
{
    [Serializable]
    public class QuaternionEvent : UnityEvent<Quaternion> { }
}
