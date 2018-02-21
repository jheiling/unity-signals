using System;
using UnityEngine;



namespace Signals.Common
{
    [Serializable]
    public class Vector2ValueReference : ValueReference<Vector2, Vector2Event, Vector2Signal>
    {
        public Vector2ValueReference() { }
        public Vector2ValueReference(Vector2 localValue) : base(localValue) { }
    }
}
