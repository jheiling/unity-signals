using UnityEngine;

namespace Signals.Extras.Engine
{
    [CreateAssetMenu(fileName = "Time", menuName = nameof(Signals) + "/" + nameof(Extras) + "/" + nameof(Engine) + "/" + nameof(TimeWrapper))]
    public class TimeWrapper : ScriptableObject
    {
        public float FixedDeltaTime
        {
            get => Time.fixedDeltaTime;
            set => Time.fixedDeltaTime = value;
        }

        public float MaximumDeltaTime
        {
            get => Time.maximumDeltaTime;
            set => Time.maximumDeltaTime = value;
        }

        public float TimeScale
        {
            get => Time.timeScale;
            set => Time.timeScale = value;
        }

        public float MaximumParticleDeltaTime
        {
            get => Time.maximumParticleDeltaTime;
            set => Time.maximumParticleDeltaTime = value;
        }

        public int CaptureFramerate
        {
            get => Time.captureFramerate;
            set => Time.captureFramerate = value;
        }
    }
}