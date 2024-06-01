//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CodeBase.Components.Camera;

public partial class GameEntity {

    public CameraComponent camera { get { return (CameraComponent)GetComponent(GameComponentsLookup.Camera); } }
    public bool hasCamera { get { return HasComponent(GameComponentsLookup.Camera); } }

    public void AddCamera(UnityEngine.Camera newCamera) {
        var index = GameComponentsLookup.Camera;
        var component = (CameraComponent)CreateComponent(index, typeof(CameraComponent));
        component.Camera = newCamera;
        AddComponent(index, component);
    }

    public void ReplaceCamera(UnityEngine.Camera newCamera) {
        var index = GameComponentsLookup.Camera;
        var component = (CameraComponent)CreateComponent(index, typeof(CameraComponent));
        component.Camera = newCamera;
        ReplaceComponent(index, component);
    }

    public void RemoveCamera() {
        RemoveComponent(GameComponentsLookup.Camera);
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

    static Entitas.IMatcher<GameEntity> _matcherCamera;

    public static Entitas.IMatcher<GameEntity> Camera {
        get {
            if (_matcherCamera == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Camera);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCamera = matcher;
            }

            return _matcherCamera;
        }
    }
}
