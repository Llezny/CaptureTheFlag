using PlayerStates;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
  public class PlayerMovementBehaviour : MonoBehaviour {

    [ Header( "References" ) ]
    [ SerializeField ] private Rigidbody playerRigidbody;

    [ Header( "Movement Settings" ) ]
    [ SerializeField ] private float playerSpeed = 10;
    [ SerializeField ] private float runningSpeedModifier = 2;
    [ SerializeField ] private float jumpForce = 20f;
    
    private Vector3 movementVector;
    private float moveMultiplier;

    private void FixedUpdate( ) {
      playerRigidbody.AddForce( playerRigidbody.transform.TransformDirection(movementVector) * playerSpeed );
    }

    private void OnEnable( ) {
      AddListeners( );
    }
    
    private void OnDisable( ) {
      RemoveListeners( );
    }

    private void AddListeners( ) {
      InputReceiverBehaviour.OnMovePressed += Move;
      InputReceiverBehaviour.OnRunPressed += Run;
      InputReceiverBehaviour.OnJumpPressed += Jump;
    }

    private void RemoveListeners( ) {
      InputReceiverBehaviour.OnMovePressed -= Move;
      InputReceiverBehaviour.OnRunPressed -= Run;
      InputReceiverBehaviour.OnJumpPressed -= Jump;
    }

    private bool IsGrounded( ) {
      return Physics.Raycast( transform.position, -Vector3.up, 1f );
    }

    private void Move( InputValue inputValue ) {
      var inputVector = inputValue.Get<Vector2>( );
      movementVector = new Vector3( inputVector.x, 0, inputVector.y );
    }
  
    private void Run( InputValue inputValue ) {
      runningSpeedModifier = inputValue.isPressed ? 2 : 1;
    }
  
    private void Jump( InputValue inputValue ) {
      if ( !inputValue.isPressed || !IsGrounded( ) ) {
        return;
      }
      playerRigidbody.AddForce( Vector3.up * jumpForce );
    }
  }
}
