using UnityEngine;
using Signals.Common;



namespace Signals.Examples
{
    [AddComponentMenu("Signals/Examples/Name")]
    public class Name : ValueReferenceComponent<string, StringEvent, StringSignal, StringValueReference> { }
}