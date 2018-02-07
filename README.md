# Signals For Unity3D
## Documentation
You can find the API documentation [here](https://jheiling.github.io/unity-signals/) or in the docs folder.
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
Copy everything except for the docs folder (the .js files confuse Unity) somewhere into your project's Asset folder.
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
public class FloatSignal : Signal<float, FloatEvent>
{
    protected override bool ValidateValue(float value)
    {
        return Value != value;
    }
}
```
By default signals will trigger the OnChanged event whenever a new value is assigned.
By overriding the ValidateValue method you can validate the value and/or add a check to avoid unnecessarily triggering the event.

Then create an editor class for your signal:
```c#
[UnityEditor.CustomEditor(typeof(FloatSignal))]
public class FloatSignalEditor : SignalEditor<float, FloatEvent>
{
    protected override void ValueField(Signal<float, FloatEvent> signal)
    {
        var value = EditorGUILayout.DelayedFloatField(signal);
        if (value != signal) signal.Value = value;
    }
}
```
Overriding the ValueField method allows you to change the signal's value in the editor when the application is running.
By default the value will be shown, but isn't editable.  
You must check whether the value was really changed to avoid unnecessary value updates.
### Implementing A SignalListener
By inheriting from SignalListener you can create a Component that listens to a signal's OnChanged event and propagates it:
```c#
public class FloatSignalListener : SignalListener<float, FloatEvent, FloatSignal> { }
```
### Implementing A ValueReference
By inheriting from ValueReference you can use serializable fields in your scripts that can either hold a local value or a reference to a signal's value:
```c#
[System.Serializable]
public class FloatValueReference : ValueReference<float, FloatEvent, FloatSignal> { }
```

And to make it look nice in the editor:
```c#
[UnityEditor.CustomPropertyDrawer(typeof(FloatValueReference))]
public class FloatValueReferenceDrawer : ValueReferenceDrawer { }
```
### Code Generation
You can find a simple code generator that can save you a lot of work [here](https://github.com/jheiling/unity-signals-generator).
### Example
See Example folder.
## Credits
Signals was inspired by Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) about game architecture with ScriptableObjects.
I also nicked a bit of his code for the ValueReferenceDrawer class. You can find the source [here](https://github.com/roboryantron/Unite2017).