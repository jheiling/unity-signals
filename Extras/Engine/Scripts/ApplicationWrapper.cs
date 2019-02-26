using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(fileName = "Application", menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(ApplicationWrapper))]
    public class ApplicationWrapper : ScriptableObject
    {
        public int TargetFrameRate
        {
            get => Application.targetFrameRate;
            set => Application.targetFrameRate = value;
        }

        public bool RunInBackground
        {
            get => Application.runInBackground;
            set => Application.runInBackground = value;
        }

        public ThreadPriority BackgroundLoadingPriority
        {
            get => Application.backgroundLoadingPriority;
            set => Application.backgroundLoadingPriority = value;
        }
    }
}