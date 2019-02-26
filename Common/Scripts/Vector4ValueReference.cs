using System;
using UnityEngine;

namespace Signals.Common
{
    [Serializable]
    public class Vector4ValueReference : ValueReference<Vector4, Vector4Event, Vector4Signal>
    {
        public Vector4ValueReference() { }
        public Vector4ValueReference(Vector4 localValue) : base(localValue) { }
    }
}
