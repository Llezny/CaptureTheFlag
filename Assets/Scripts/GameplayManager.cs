using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using Player;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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
        PauseGame( );
    }

    public void RestartGame( ) {
        SceneLoader.Instance.LoadScene( SceneName.Game );
    }

    public void QuitGame( ) {
        SceneLoader.Instance.LoadScene( SceneName.MainMenu );
    }
    
    public void PauseGame( ) {
        Debug.Log( PausedGame ? "unpause" : "pause" );
        PausedGame = !PausedGame;
        Time.timeScale = PausedGame ? 0 : 1;
        OnPausedGame?.Invoke( PausedGame );
    }
}
