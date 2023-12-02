using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<int>))]
    public class IntValueReferenceDrawer : ValueReferenceDrawer { }
}
