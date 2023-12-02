using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<string>))]
    public class StringValueReferenceDrawer : ValueReferenceDrawer { }
}