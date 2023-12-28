# Signals For Unity3D v3.0.0

Tested with Unity 2022.3.14f1 LTS

## Documentation

You can find the API documentation [here](https://jheiling.github.io/unity-signals/).

## What Are Signals?

A Signal is a [ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html) which holds a value and triggers a [UnityEvent](https://docs.unity3d.com/ScriptReference/Events.UnityEvent_1.html) when a new value is assigned.

## Why Should I Use Them?

Because ScriptableObjects are a good choice to create a sane architecture for games made with Unity.
They allow you to nicely decouple systems and avoid direct references between scene objects.
For an in depth explanation I would highly recommend watching [Richard Fine's](https://www.youtube.com/watch?v=6vmRwLYWNRo) and [Ryan Hipple's](https://www.youtube.com/watch?v=raQ3iHhE_Kk) talks.

If you store a value in a ScriptableObject you might want to get notified when the value changes.
On the other hand it can be useful to keep the last value an event was invoked with around.
Signals are a solution for both use cases.

## Installation

Copy everything somewhere into your project's Asset folder.

## Usage

### Implementing A Signal

Create a class for the signal:

```c#
[UnityEngine.CreateAssetMenu]
public class FloatSignal : Signal<float> { }
```

By default signals will trigger the OnChanged event whenever a new value is assigned.
By overriding the ValidateValue method you can validate the value and/or add a check to avoid unnecessarily triggering the event.
By default ValidateValue will use the Equals method for this check.

If you want to have a nice inspector create an editor class for your signal and override the ValueField method:

```c#
[UnityEditor.CustomEditor(typeof(Signal<float>))]
public class FloatSignalEditor : SignalEditor<float>
{
    protected override float ValueField(float value) => EditorGUILayout.DelayedFloatField(value);
}
```

### Implementing A SignalListener

By inheriting from SignalListener you can create a Component that listens to a signal's OnChanged event and propagates it:

```c#
public class FloatSignalListener : SignalListener<float> { }
```

### Examples

See Examples folder.

## Credits

Signals was inspired by Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) about game architecture with ScriptableObjects.
