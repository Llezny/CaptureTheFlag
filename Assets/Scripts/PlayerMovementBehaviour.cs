using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityTemplateProjects;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovementBehaviour : MonoBehaviour {

  [ Header( "References" ) ]
  [ SerializeField ] private Rigidbody playerRigidbody;

  [ Header( "Movement Settings" ) ]
  [ SerializeField ] private float playerSpeed = 10;
  [ SerializeField ] private float runningSpeedModifier = 2;
  [ SerializeField ] private float jumpForce = 20f;

  private PlayerMovementStateMachine playerMovementStateMachine;
  private Vector3 movementVector;
  private float moveMultiplier;

  private void Awake( ) {
    playerMovementStateMachine = new PlayerMovementStateMachine( new IdlePlayerState(), this );
  }

  private void FixedUpdate( ) {
    playerRigidbody.AddForce( playerRigidbody.transform.TransformDirection(movementVector) * playerSpeed );
  }

  private void Update( ) {
    playerMovementStateMachine.Update();
  }

  private void OnEnable( ) {
    AddListeners( );
 //   SceneLinkedSMB<PlayerMovementBehaviour>.Initialise( animator, this );
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

  private void Move( InputValue inputValue ) {
    var inputVector = inputValue.Get<Vector2>( );
    movementVector = new Vector3( inputVector.x, 0, inputVector.y );
  }
  
  private void Run( InputValue inputValue ) {
    runningSpeedModifier = inputValue.isPressed ? 2 : 1;
  }
  
  private void Jump( InputValue inputValue ) {
    if ( !inputValue.isPressed )
      return;
    playerRigidbody.AddForce( Vector3.up * jumpForce );
  }
  
  
}
