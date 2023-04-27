using Player;
using SimpleDependencyInjection;
using UnityEngine;

public class UIDependenciesContext : DependenciesContext {

    [SerializeField] private PlayerHealthBehaviour playerHealthBehaviour;
    [SerializeField] private GameplayManager gameplayManager;
    [SerializeField] private StopwatchBehaviour stopwatchBehaviour;
    [SerializeField] private FlagSystem flagSystem;
    
    protected override void Setup( ) {
        dependenciesCollection.Add(new Dependency { Type = typeof(PlayerHealthBehaviour), Factory = DependencyFactory.FromGameObject( playerHealthBehaviour ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(GameplayManager), Factory = DependencyFactory.FromGameObject( gameplayManager ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(StopwatchBehaviour), Factory = DependencyFactory.FromGameObject( stopwatchBehaviour ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(FlagSystem), Factory = DependencyFactory.FromGameObject( flagSystem ), IsSingleton = false });
    }

    protected override void Configure( ) {

    }
}
