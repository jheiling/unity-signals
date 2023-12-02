using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<Vector2>))]
    public class Vector2ValueReferenceDrawer : ValueReferenceDrawer { }
}
