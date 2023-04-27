using System.Collections;
using System.Collections.Generic;
using Common;
using Player;
using SimpleDependencyInjection;
using UnityEngine;

public class UIDependenciesContext : DependenciesContext {

    [SerializeField] private PlayerHealthBehaviour playerHealthBehaviour;
    [SerializeField] private GameplayManager gameplayManager;
    [SerializeField] private StopwatchBehaviour stopwatchBehaviour;
    
    protected override void Setup( ) {
        dependenciesCollection.Add(new Dependency { Type = typeof(PlayerHealthBehaviour), Factory = DependencyFactory.FromGameObject( playerHealthBehaviour ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(GameplayManager), Factory = DependencyFactory.FromGameObject( gameplayManager ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(StopwatchBehaviour), Factory = DependencyFactory.FromGameObject( stopwatchBehaviour ), IsSingleton = false });
    }

    protected override void Configure( ) {

    }
}
