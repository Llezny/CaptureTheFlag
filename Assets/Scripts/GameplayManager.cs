using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GameplayManager : MonoBehaviour {

    public static UnityEvent<bool> OnPausedGame = new UnityEvent<bool>(  );
    public bool PausedGame { get; private set; }
    
    private void OnEnable( ) {
        InputReceiverBehaviour.OnPausePressed += PauseGame;
    }
    
    private void OnDisable( ) {
        InputReceiverBehaviour.OnPausePressed -= PauseGame;
    }

    public void PauseGame( InputValue inputValue ) {
        PausedGame = !PausedGame;
        Time.timeScale = PausedGame ? 0 : 1;
        OnPausedGame?.Invoke( PausedGame );
    }
}
