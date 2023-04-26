using SimpleDependencyInjection;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    [InjectField] private GameplayManager gameplayManager; 
    
    [ SerializeField ] private GameObject content;

    private void OnEnable( ) {
        GameplayManager.OnPausedGame.AddListener( ToggleMenu );
    }

    private void OnDisable( ) {
        GameplayManager.OnPausedGame.RemoveListener( ToggleMenu );
    }

    public void Resume( ) {
        gameplayManager.PauseGame();
    }

    public void Restart( ) {
        
    }

    public void Quit( ) {
        
    }
    
    public void ToggleMenu( bool enable ) {
        content.SetActive( enable );
    }
}
