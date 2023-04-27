using System;
using CaptureTheFlag.Common.Manager;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CaptureTheFlag.Player.Movement {
    [RequireComponent(typeof(PlayerInput))]
    public class InputReceiverBehaviour : MonoBehaviour {

        public static Action<InputValue> OnMovePressed;
        public static Action<InputValue> OnLookPressed;
        public static Action<InputValue> OnFirePressed;
        public static Action<InputValue> OnJumpPressed;
        public static Action<InputValue> OnRunPressed;
        public static Action<InputValue> OnPausePressed;
        public static Action OnAnyKeyPressed;


        private PlayerInput playerInput;
        private const string INPUT_MAP_UI = "UI";
        private const string INPUT_MAP_PLAYER = "Player";
    
        public void SetInputMap( bool mapInput ) {
            if ( mapInput ) {
                playerInput.SwitchCurrentActionMap( INPUT_MAP_UI );
                return;
            }
            playerInput.SwitchCurrentActionMap( INPUT_MAP_PLAYER );
        }

        private void SetUIInputMap( bool _ ) {
            SetInputMap( true );
        }

        private void Awake( ) {
            playerInput = GetComponent<PlayerInput>( );
        }

        private void OnEnable( ) {
            GameplayManager.OnPausedGame.AddListener( SetInputMap );
            GameplayManager.OnGameFinish.AddListener( SetUIInputMap );
        }

        private void OnDisable( ) {
            GameplayManager.OnPausedGame.RemoveListener( SetInputMap );
            GameplayManager.OnGameFinish.RemoveListener( SetUIInputMap );
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
        
        private void OnAny( ) {
            OnAnyKeyPressed?.Invoke( );
        }
    
    }
}
