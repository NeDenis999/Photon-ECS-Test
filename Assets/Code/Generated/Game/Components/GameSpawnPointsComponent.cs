//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SpawnPoints spawnPoints { get { return (SpawnPoints)GetComponent(GameComponentsLookup.SpawnPoints); } }
    public bool hasSpawnPoints { get { return HasComponent(GameComponentsLookup.SpawnPoints); } }

    public void AddSpawnPoints(UnityEngine.Vector2[] newValue) {
        var index = GameComponentsLookup.SpawnPoints;
        var component = (SpawnPoints)CreateComponent(index, typeof(SpawnPoints));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpawnPoints(UnityEngine.Vector2[] newValue) {
        var index = GameComponentsLookup.SpawnPoints;
        var component = (SpawnPoints)CreateComponent(index, typeof(SpawnPoints));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpawnPoints() {
        RemoveComponent(GameComponentsLookup.SpawnPoints);
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

    static Entitas.IMatcher<GameEntity> _matcherSpawnPoints;

    public static Entitas.IMatcher<GameEntity> SpawnPoints {
        get {
            if (_matcherSpawnPoints == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnPoints);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnPoints = matcher;
            }

            return _matcherSpawnPoints;
        }
    }
}
