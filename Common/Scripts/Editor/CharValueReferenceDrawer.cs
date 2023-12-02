using UnityEditor;

namespace Signals.Common
{
    [CustomPropertyDrawer(typeof(ValueReference<char>))]
    public class CharValueReferenceDrawer : ValueReferenceDrawer { }
}
