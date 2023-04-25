using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputReceiverBehaviour : MonoBehaviour {

    public Action<InputValue> OnMovePressed;
    public Action<InputValue> OnLookPressed;
    public Action<InputValue> OnFirePressed;
    public Action<InputValue> OnJumpPressed;
    public Action<InputValue> OnRunPressed;

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
    
}
