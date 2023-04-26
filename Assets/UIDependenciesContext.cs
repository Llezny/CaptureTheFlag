using System.Collections;
using System.Collections.Generic;
using SimpleDependencyInjection;
using UnityEngine;

public class UIDependenciesContext : DependenciesContext {
    [SerializeField] private PlayerHealthBehaviour playerHealthBehaviour;
    [SerializeField] private InputReceiverBehaviour inputReceiver;
    
    protected override void Setup( ) {
        dependenciesCollection.Add(new Dependency { Type = typeof(PlayerHealthBehaviour), Factory = DependencyFactory.FromGameObject( playerHealthBehaviour ), IsSingleton = false });
        dependenciesCollection.Add(new Dependency { Type = typeof(InputReceiverBehaviour), Factory = DependencyFactory.FromGameObject( inputReceiver ), IsSingleton = false });
    }

    protected override void Configure( ) {

    }
}
