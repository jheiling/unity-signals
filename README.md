# Signals For Unity3D
## What Are Signals?
A Signal is a [ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html) which holds a value and triggers a [UnityEvent](https://docs.unity3d.com/ScriptReference/Events.UnityEvent_1.html) when a new value is assigned.
## Why Should I Use Them?
Because ScriptableObjects are a good choice to create a sane architecture for games made with Unity.
They allow you to nicely decouple systems and avoid direct references between scene objects. 
For an in depth explanation I would highly recommend watching [Richard Fine's](https://www.youtube.com/watch?v=6vmRwLYWNRo) and [Ryan Hipple's](https://www.youtube.com/watch?v=raQ3iHhE_Kk) talks.
The reasoning behind signals is that you often want to be notified when a referenced value changes, and also it's often useful to keep the last value some event was invoked with around.
Signals are a solution for both use cases.
## How To Use Signals
First you need to create a class for the UnityEvent:
```c#
[System.Serializable]
public class FloatEvent : UnityEvent<float> { }
```

Next create a class for the signal:
```c#
[UnityEngine.CreateAssetMenu]
public class FloatSignal : Signal<float, FloatEvent>
{
    protected override bool HasChanged(float value)
    {
        return Value != value;
    }
}
```
By default signals will trigger the OnChanged event whenever a new value is assigned. By overriding the HasChanged method you can add a check to avoid unnecessarily triggering the event.

Then create an editor class for your signal:
```c#
[UnityEditor.CustomEditor(typeof(FloatSignal))]
public class FloatSignalEditor : SignalEditor<float, FloatEvent>
{
    protected override void ValueField(Signal<float, FloatEvent> signal)
    {
        signal.Value = UnityEditor.EditorGUILayout.DelayedFloatField(signal.Value);
    }
}
```
By default the signal's value will be just shown in the editor when the application is running. By overriding the ValueField method you can change the signal's value in the editor.
## Using SignalListener
By inheriting from SignalListener you can create a Component that listenes to a signal's OnChanged event and propagates it:
```c#
public class FloatSignalListener : SignalListener<float, FloatEvent, FloatSignal> { }
```
## Using ValueReference
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
## Examples
In the Common folder you will find the source for FloatEvent, FloatSignal, FloatSignalEditor, FloatSignalListener, FloatValueReference, and FloatValueReferenceDrawer.
## Credits
Signals was inspired by Ryan Hipple's [talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) about game architecture with ScriptableObjects. 
I also nicked a bit of his code for the ValueReferenceDrawer class. You can find the source [here](https://github.com/roboryantron/Unite2017).