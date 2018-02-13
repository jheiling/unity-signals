using UnityEngine;



namespace Signals.Utils.Engine
{
    [CreateAssetMenu(fileName = "Time", menuName = "Signals/Utils/Engine/TimeWrapper")]
    public class TimeWrapper : ScriptableObject
    {
        public float FixedDeltaTime
        {
            get
            {
                return Time.fixedDeltaTime;
            }

            set
            {
                Time.fixedDeltaTime = value;
            }
        }

        public float MaximumDeltaTime
        {
            get
            {
                return Time.maximumDeltaTime;
            }

            set
            {
                Time.maximumDeltaTime = value;
            }
        }

        public float TimeScale
        {
            get
            {
                return Time.timeScale;
            }

            set
            {
                Time.timeScale = value;
            }
        }

        public float MaximumParticleDeltaTime
        {
            get
            {
                return Time.maximumParticleDeltaTime;
            }

            set
            {
                Time.maximumParticleDeltaTime = value;
            }
        }

        public int CaptureFramerate
        {
            get
            {
                return Time.captureFramerate;
            }

            set
            {
                Time.captureFramerate = value;
            }
        }
    }
}