using System.Collections;
using System.Collections.Generic;
using Player;
using SimpleDependencyInjection;
using UnityEngine;

public class StartPopup : MonoBehaviour {
    
    [ InjectField ] private GameplayManager gameplayManager; 
    private void OnEnable( ) {
        InputReceiverBehaviour.OnAnyKeyPressed += DestroyItself;
        gameplayManager.PauseGame();
    }

    private void OnDisable( ) {
        InputReceiverBehaviour.OnAnyKeyPressed -= DestroyItself;
        gameplayManager.PauseGame();
    }

    private void DestroyItself( ) {
        Destroy( this.gameObject );
    }
}
