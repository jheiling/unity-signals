using System;
using UnityEngine;



namespace Signals.Common
{
    [Serializable]
    public class QuaternionValueReference : ValueReference<Quaternion, QuaternionEvent, QuaternionSignal> { }
}
