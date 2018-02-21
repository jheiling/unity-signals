using System;
using UnityEngine;



namespace Signals.Extras.Engine
{
    [Serializable]
    public class TimeSettings : ISettings
    {
        [SerializeField] float _fixedDeltaTime = .02f;
        [SerializeField] float _maximumDeltaTime = .3333333f;
        [SerializeField] float _timeScale = 1f;
        [SerializeField] float _maximumParticleDeltaTime = .03f;
        [SerializeField] int _captureFramerate;

        public float FixedDeltaTime
        {
            get
            {
                return _fixedDeltaTime;
            }

            set
            {
                _fixedDeltaTime = value;
            }
        }

        public float MaximumDeltaTime
        {
            get
            {
                return _maximumDeltaTime;
            }

            set
            {
                _maximumDeltaTime = value;
            }
        }

        public float TimeScale
        {
            get
            {
                return _timeScale;
            }

            set
            {
                _timeScale = value;
            }
        }

        public float MaximumParticleDeltaTime
        {
            get
            {
                return _maximumParticleDeltaTime;
            }

            set
            {
                _maximumParticleDeltaTime = value;
            }
        }

        public int CaptureFramerate
        {
            get
            {
                return _captureFramerate;
            }

            set
            {
                _captureFramerate = value;
            }
        }

        public void SetToCurrent()
        {
            _fixedDeltaTime = Time.fixedDeltaTime;
            _maximumDeltaTime = Time.maximumDeltaTime;
            _timeScale = Time.timeScale;
            _maximumParticleDeltaTime = Time.maximumParticleDeltaTime;
            _captureFramerate = Time.captureFramerate;
        }

        public void Apply()
        {
            Time.fixedDeltaTime = _fixedDeltaTime;
            Time.maximumDeltaTime = _maximumDeltaTime;
            Time.timeScale = _timeScale;
            Time.maximumParticleDeltaTime = _maximumParticleDeltaTime;
            Time.captureFramerate = _captureFramerate;
        }
    }
}