using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<Vector3>))]
    public class Vector3ValueReferenceDrawer : ValueReferenceDrawer { }
}