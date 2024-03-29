﻿using UnityEngine;
using UnityEditor;

namespace Signals.Common
{
    [CustomEditor(typeof(Vector3Signal), true)]
    public class Vector3SignalEditor : SignalEditor<Vector3>
    {
        protected override Vector3 ValueField(Vector3 value) => EditorGUILayout.Vector3Field("", value);
    }
}