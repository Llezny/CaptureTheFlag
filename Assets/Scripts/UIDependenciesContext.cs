using System.Collections;
using System.Collections.Generic;
using Player;
using SimpleDependencyInjection;
using UnityEngine;

public class UIDependenciesContext : DependenciesContext {
    [SerializeField] private PlayerHealthBehaviour playerHealthBehaviour;
    [SerializeField] private GameplayManager gameplayManager;
    
    protected override void Setup( ) {
        dependenciesCollection.Add(new Dependency { Type = typeof(PlayerHealthBehaviour), Factory = DependencyFactory.FromGameObject( playerHealthBehaviour ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(GameplayManager), Factory = DependencyFactory.FromGameObject( gameplayManager ), IsSingleton = false });
    }

    protected override void Configure( ) {

    }
}
