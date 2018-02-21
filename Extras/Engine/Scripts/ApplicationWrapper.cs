using UnityEngine;



namespace Signals.Extras.Engine
{
    [CreateAssetMenu(fileName = "Application", menuName = "Signals/Extras/Engine/ApplicationWrapper")]
    public class ApplicationWrapper : ScriptableObject
    {
        public int TargetFrameRate
        {
            get
            {
                return Application.targetFrameRate;
            }

            set
            {
                Application.targetFrameRate = value;
            }
        }

        public bool RunInBackground
        {
            get
            {
                return Application.runInBackground;
            }

            set
            {
                Application.runInBackground = value;
            }
        }

        public ThreadPriority BackgroundLoadingPriority
        {
            get
            {
                return Application.backgroundLoadingPriority;
            }

            set
            {
                Application.backgroundLoadingPriority = value;
            }
        }
    }
}