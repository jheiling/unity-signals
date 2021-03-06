﻿using UnityEngine;
using UnityEditor;

namespace Signals.Extras.Engine
{
    public abstract class EngineWrapperEditor<T> : Editor where T : Object
    {
        public override void OnInspectorGUI() { if (Application.isPlaying) OnPlayingInspectorGUI(target as T); }
        protected abstract void OnPlayingInspectorGUI(T wrapper);
        public override bool RequiresConstantRepaint() => true;
    }
}