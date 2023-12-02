using UnityEngine;

namespace Signals.Examples
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Examples) + "/" + nameof(Name))]
    public class Name : ValueReferenceComponent<string> { }
}