using Common;
using Player;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GameplayManager : MonoBehaviour {

    public static UnityEvent<bool> OnPausedGame = new UnityEvent<bool>(  );
    public static UnityEvent<bool> OnGameFinish = new UnityEvent<bool>(  );

    public void Awake( ) {
        Time.timeScale = 1;
    }

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

    public static void WinGame( ) {
        OnGameFinish?.Invoke( true );
    }
    
    public static void LoseGame( ) {
        OnGameFinish?.Invoke( false );
    }

    public void PauseGame( ) {
        PausedGame = !PausedGame;
        Time.timeScale = PausedGame ? 0 : 1;
        OnPausedGame?.Invoke( PausedGame );
    }
}
