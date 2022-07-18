//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly ConnectButton connectButtonComponent = new ConnectButton();

    public bool isConnectButton {
        get { return HasComponent(GameComponentsLookup.ConnectButton); }
        set {
            if (value != isConnectButton) {
                var index = GameComponentsLookup.ConnectButton;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : connectButtonComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherConnectButton;

    public static Entitas.IMatcher<GameEntity> ConnectButton {
        get {
            if (_matcherConnectButton == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ConnectButton);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherConnectButton = matcher;
            }

            return _matcherConnectButton;
        }
    }
}
