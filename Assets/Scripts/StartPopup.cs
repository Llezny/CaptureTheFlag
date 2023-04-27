using Player;
using SimpleDependencyInjection;
using UnityEngine;

public class StartPopup : MonoBehaviour {
    
    [ InjectField ] private GameplayManager gameplayManager; 
    private void Awake( ) {
        InputReceiverBehaviour.OnAnyKeyPressed += DestroyItself;
        gameplayManager.PauseGame();
    }

    private void OnDestroy( ) {
        InputReceiverBehaviour.OnAnyKeyPressed -= DestroyItself;
        gameplayManager.PauseGame();
    }

    private void DestroyItself( ) {
        Destroy( this.gameObject );
    }
}
