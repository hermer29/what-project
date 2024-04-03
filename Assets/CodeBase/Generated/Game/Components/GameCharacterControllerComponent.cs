//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CodeBase.Components.CharacterControllerComponent characterController { get { return (CodeBase.Components.CharacterControllerComponent)GetComponent(GameComponentsLookup.CharacterController); } }
    public bool hasCharacterController { get { return HasComponent(GameComponentsLookup.CharacterController); } }

    public void AddCharacterController(UnityEngine.AI.NavMeshAgent newCharacterController) {
        var index = GameComponentsLookup.CharacterController;
        var component = (CodeBase.Components.CharacterControllerComponent)CreateComponent(index, typeof(CodeBase.Components.CharacterControllerComponent));
        component.CharacterController = newCharacterController;
        AddComponent(index, component);
    }

    public void ReplaceCharacterController(UnityEngine.AI.NavMeshAgent newCharacterController) {
        var index = GameComponentsLookup.CharacterController;
        var component = (CodeBase.Components.CharacterControllerComponent)CreateComponent(index, typeof(CodeBase.Components.CharacterControllerComponent));
        component.CharacterController = newCharacterController;
        ReplaceComponent(index, component);
    }

    public void RemoveCharacterController() {
        RemoveComponent(GameComponentsLookup.CharacterController);
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

    static Entitas.IMatcher<GameEntity> _matcherCharacterController;

    public static Entitas.IMatcher<GameEntity> CharacterController {
        get {
            if (_matcherCharacterController == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CharacterController);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharacterController = matcher;
            }

            return _matcherCharacterController;
        }
    }
}
