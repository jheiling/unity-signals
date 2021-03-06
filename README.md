# Signals For Unity3D v2.0.2
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
First you need to create a class for the signal's OnChanged event:
```c#
[System.Serializable]
public class FloatEvent : UnityEvent<float> { }
```

Next create a class for the signal:
```c#
[UnityEngine.CreateAssetMenu]
public class FloatSignal : Signal<float, FloatEvent> { }
```
By default signals will trigger the OnChanged event whenever a new value is assigned.
By overriding the ValidateValue method you can validate the value and/or add a check to avoid unnecessarily triggering the event.
By default ValidateValue will use the Equals method for this check.

If you want to have a nice inspector create an editor class for your signal and override the ValueField method:
```c#
[UnityEditor.CustomEditor(typeof(FloatSignal))]
public class FloatSignalEditor : SignalEditor<float, FloatEvent>
{
    protected override float ValueField(float value)
    {
        return EditorGUILayout.DelayedFloatField(value);
    }
}
```
### Implementing A SignalListener
By inheriting from SignalListener you can create a Component that listens to a signal's OnChanged event and propagates it:
```c#
public class FloatSignalListener : SignalListener<float, FloatEvent, FloatSignal> { }
```
### Implementing A ValueReference
By inheriting from ValueReference you can use serializable fields in your scripts that can either hold a local value or a reference to a signal's value:
```c#
[System.Serializable]
public class FloatValueReference : ValueReference<float, FloatEvent, FloatSignal> 
{
    public FloatValueReference() { }
    public FloatValueReference(float localValue) : base(localValue) { }
}
```

And to make it look nice in the editor:
```c#
[UnityEditor.CustomPropertyDrawer(typeof(FloatValueReference))]
public class FloatValueReferenceDrawer : ValueReferenceDrawer { }
```
### Code Generation
You can find a simple code generator that can save you a lot of work [here](https://github.com/jheiling/unity-signals-generator).
### Examples
See Examples folder.
## Credits
Signals was inspired by Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) about game architecture with ScriptableObjects.