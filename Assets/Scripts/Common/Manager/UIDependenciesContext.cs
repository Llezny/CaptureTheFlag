using CaptureTheFlag._3rdParty.SimpleDependencyInjection;
using CaptureTheFlag.Collectible;
using CaptureTheFlag.Common.Tool;
using CaptureTheFlag.Player.Stats;
using UnityEngine;

namespace CaptureTheFlag.Common.Manager {
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
    }
}
