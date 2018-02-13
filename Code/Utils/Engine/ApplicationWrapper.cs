using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(fileName = "Application", menuName = "Signals/Utils/Engine/ApplicationWrapper")]
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