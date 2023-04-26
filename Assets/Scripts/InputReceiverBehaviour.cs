using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputReceiverBehaviour : MonoBehaviour {

    public static Action<InputValue> OnMovePressed;
    public static Action<InputValue> OnLookPressed;
    public static Action<InputValue> OnFirePressed;
    public static Action<InputValue> OnJumpPressed;
    public static Action<InputValue> OnRunPressed;
    public static Action<InputValue> OnPausePressed;

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
