using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
    [ SerializeField ] private GameObject content;

    private void OnEnable( ) {
        GameplayManager.OnPausedGame.AddListener( ToggleMenu );
    }

    private void OnDisable( ) {
        GameplayManager.OnPausedGame.RemoveListener( ToggleMenu );
    }
    
    public void ToggleMenu( bool enable ) {
        content.SetActive( enable );
    }
}
