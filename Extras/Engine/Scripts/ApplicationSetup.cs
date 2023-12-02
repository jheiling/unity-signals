using UnityEngine;

namespace Signals.Extras.Engine
{
    [AddComponentMenu(nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(ApplicationSetup))]
    public class ApplicationSetup : EngineSetup<ApplicationSettings> { }
}