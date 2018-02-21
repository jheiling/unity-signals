using System;
using UnityEngine;



namespace Signals.Common
{
    [Serializable]
    public class Vector3ValueReference : ValueReference<Vector3, Vector3Event, Vector3Signal>
    {
        public Vector3ValueReference() { }
        public Vector3ValueReference(Vector3 localValue) : base(localValue) { }
    }
}