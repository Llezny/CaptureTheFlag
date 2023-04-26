using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
    [RequireComponent(typeof(PlayerInput))]
    public class InputReceiverBehaviour : MonoBehaviour {

        public static Action<InputValue> OnMovePressed;
        public static Action<InputValue> OnLookPressed;
        public static Action<InputValue> OnFirePressed;
        public static Action<InputValue> OnJumpPressed;
        public static Action<InputValue> OnRunPressed;
        public static Action<InputValue> OnPausePressed;

        private PlayerInput playerInput;
        private const string INPUT_MAP_UI = "UI";
        private const string INPUT_MAP_PLAYER = "Player";
    
        public void SetInputMap( bool isGamePaused ) {
            if ( isGamePaused ) {
                playerInput.SwitchCurrentActionMap( INPUT_MAP_UI );
                return;
            }
            playerInput.SwitchCurrentActionMap( INPUT_MAP_PLAYER );
        }

        private void Awake( ) {
            playerInput = GetComponent<PlayerInput>( );
        }

        private void OnEnable( ) {
            GameplayManager.OnPausedGame.AddListener( SetInputMap );
        }

        private void OnDisable( ) {
            GameplayManager.OnPausedGame.RemoveListener( SetInputMap );
        }

        private void OnMove( InputValue inputValue ) {
            OnMovePressed?.Invoke( inputValue );
        }
   
        private void OnLook( InputValue inputValue ) {
            OnLookPressed?.Invoke( inputValue );
        }
   
        private void OnFire( InputValue inputValue ) {
            OnFirePressed?.Invoke( inputValue );
        }
   
        private void OnJump( InputValue inputValue ) {
            OnJumpPressed?.Invoke( inputValue );
        }
        
        private void OnRun( InputValue inputValue ) {
            OnRunPressed?.Invoke( inputValue );
        }
    
        private void OnPause( InputValue inputValue ) {
            OnPausePressed?.Invoke( inputValue );
        }
    
    }
}