using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<Vector3Int>))]
    public class Vector3IntValueReferenceDrawer : ValueReferenceDrawer { }
}
