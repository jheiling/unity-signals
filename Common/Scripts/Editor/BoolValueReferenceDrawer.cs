using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<bool>))]
    public class BoolValueReferenceDrawer : ValueReferenceDrawer { }
}
