using UnityEditor;
using UnityEngine;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<Vector2Int>))]
    public class Vector2IntValueReferenceDrawer : ValueReferenceDrawer { }
}
