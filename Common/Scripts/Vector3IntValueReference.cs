using System;
using UnityEngine;

namespace Signals.Common
{
    [Serializable]
    public class Vector3IntValueReference : ValueReference<Vector3Int, Vector3IntEvent, Vector3IntSignal>
    {
        public Vector3IntValueReference() { }
        public Vector3IntValueReference(Vector3Int localValue) : base(localValue) { }
    }
}
