using CaptureTheFlag._3rdParty.SimpleDependencyInjection;
using CaptureTheFlag.Common.Manager;
using UnityEngine;

namespace CaptureTheFlag.View {
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
            gameplayManager.RestartGame();
        }

        public void Quit( ) {
            gameplayManager.QuitGame();
        }
    
        public void ToggleMenu( bool enable ) {
            content.SetActive( enable );
        }
    }
}
