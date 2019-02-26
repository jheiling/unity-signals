using System;
using UnityEngine;

namespace Signals.Common
{
    [Serializable]
    public class QuaternionValueReference : ValueReference<Quaternion, QuaternionEvent, QuaternionSignal>
    {
        public QuaternionValueReference() { }
        public QuaternionValueReference(Quaternion localValue) : base(localValue) { }
    }
}
