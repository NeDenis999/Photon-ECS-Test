//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PressedListenerComponent pressedListener { get { return (PressedListenerComponent)GetComponent(GameComponentsLookup.PressedListener); } }
    public bool hasPressedListener { get { return HasComponent(GameComponentsLookup.PressedListener); } }

    public void AddPressedListener(System.Collections.Generic.List<IPressedListener> newValue) {
        var index = GameComponentsLookup.PressedListener;
        var component = (PressedListenerComponent)CreateComponent(index, typeof(PressedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePressedListener(System.Collections.Generic.List<IPressedListener> newValue) {
        var index = GameComponentsLookup.PressedListener;
        var component = (PressedListenerComponent)CreateComponent(index, typeof(PressedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePressedListener() {
        RemoveComponent(GameComponentsLookup.PressedListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPressedListener;

    public static Entitas.IMatcher<GameEntity> PressedListener {
        get {
            if (_matcherPressedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PressedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPressedListener = matcher;
            }

            return _matcherPressedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddPressedListener(IPressedListener value) {
        var listeners = hasPressedListener
            ? pressedListener.value
            : new System.Collections.Generic.List<IPressedListener>();
        listeners.Add(value);
        ReplacePressedListener(listeners);
    }

    public void RemovePressedListener(IPressedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = pressedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemovePressedListener();
        } else {
            ReplacePressedListener(listeners);
        }
    }
}
