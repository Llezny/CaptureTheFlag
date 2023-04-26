using System.Collections;
using System.Collections.Generic;
using SimpleDependencyInjection;
using UnityEngine;

public class UIDependenciesContext : DependenciesContext {
    [SerializeField] private PlayerHealthBehaviour playerHealthBehaviour;
    protected override void Setup( ) {
        dependenciesCollection.Add(new Dependency { Type = typeof(PlayerHealthBehaviour), Factory = DependencyFactory.FromGameObject( playerHealthBehaviour ), IsSingleton = false });
    }

    protected override void Configure( ) {

    }
}
