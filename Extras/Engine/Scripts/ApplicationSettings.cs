using System;
using UnityEngine;



namespace Signals.Extras.Engine
{
    [Serializable]
    public class ApplicationSettings : ISettings
    {
        [SerializeField] int _targetFrameRate = -1;
        [SerializeField] bool _runInBackground;
        [SerializeField] ThreadPriority _backgroundLoadingPriority = ThreadPriority.BelowNormal;

        public int TargetFrameRate
        {
            get
            {
                return _targetFrameRate;
            }

            set
            {
                _targetFrameRate = value;
            }
        }

        public bool RunInBackground
        {
            get
            {
                return _runInBackground;
            }

            set
            {
                _runInBackground = value;
            }
        }

        public ThreadPriority BackgroundLoadingPriority
        {
            get
            {
                return _backgroundLoadingPriority;
            }

            set
            {
                _backgroundLoadingPriority = value;
            }
        }

        public void Apply()
        {
            Application.targetFrameRate = _targetFrameRate;
            Application.runInBackground = _runInBackground;
            Application.backgroundLoadingPriority = _backgroundLoadingPriority;
        }

        public void SetToCurrent()
        {
            _targetFrameRate = Application.targetFrameRate;
            _runInBackground = Application.runInBackground;
            _backgroundLoadingPriority = Application.backgroundLoadingPriority;
        }
    }
}