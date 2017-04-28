//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Vector3Component vector3 { get { return (Vector3Component)GetComponent(GameComponentsLookup.Vector3); } }
    public bool hasVector3 { get { return HasComponent(GameComponentsLookup.Vector3); } }

    public void AddVector3(UnityEngine.Vector3 newVector3) {
        var index = GameComponentsLookup.Vector3;
        var component = CreateComponent<Vector3Component>(index);
        component.vector3 = newVector3;
        AddComponent(index, component);
    }

    public void ReplaceVector3(UnityEngine.Vector3 newVector3) {
        var index = GameComponentsLookup.Vector3;
        var component = CreateComponent<Vector3Component>(index);
        component.vector3 = newVector3;
        ReplaceComponent(index, component);
    }

    public void RemoveVector3() {
        RemoveComponent(GameComponentsLookup.Vector3);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherVector3;

    public static Entitas.IMatcher<GameEntity> Vector3 {
        get {
            if (_matcherVector3 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Vector3);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVector3 = matcher;
            }

            return _matcherVector3;
        }
    }
}
