using System;
using UnityEngine;



namespace Signals.Common
{
    [Serializable]
    public class Vector2IntValueReference : ValueReference<Vector2Int, Vector2IntEvent, Vector2IntSignal>
    {
        public Vector2IntValueReference() { }
        public Vector2IntValueReference(Vector2Int localValue) : base(localValue) { }
    }
}
