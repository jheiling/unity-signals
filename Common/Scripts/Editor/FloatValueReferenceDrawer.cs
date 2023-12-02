using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<float>))]
    public class FloatValueReferenceDrawer : ValueReferenceDrawer { }
}