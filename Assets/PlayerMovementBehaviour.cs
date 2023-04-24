using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityTemplateProjects;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovementBehaviour : MonoBehaviour {

  [ SerializeField ] private CharacterController playerController;
  [ SerializeField ] private InputReceiverBehaviour inputReceiverBehaviour;
  [ SerializeField ] private float playerSpeed = 0.5f;
  
  private PlayerMovementStateMachine playerMovementStateMachine;
  private Vector3 movementVector;

  private void FixedUpdate( ) {
    
    playerController.Move( playerController.transform.TransformDirection(movementVector) * playerSpeed );
  }
  
  private void OnEnable( ) {
    AddListeners( );
  }
    
  private void OnDisable( ) {
    RemoveListeners( );
  }

  private void AddListeners( ) {
    inputReceiverBehaviour.OnMovePressed += Move;
    inputReceiverBehaviour.OnRunPressed += Run;
  //  inputReceiverBehaviour.OnJumpPressed += Jump;
  }

  private void RemoveListeners( ) {
    inputReceiverBehaviour.OnMovePressed -= Move;
    inputReceiverBehaviour.OnRunPressed -= Run;
  //  inputReceiverBehaviour.OnJumpPressed -= Jump;
  }

  private void Move( InputValue inputValue ) {
    var inputVector = inputValue.Get<Vector2>( );
    movementVector = new Vector3( inputVector.x, 0, inputVector.y );
  }
  
  private void Run( InputValue inputValue ) {
  }
  
  private void Jump( CallbackContext callbackContext ) {
    
  }

  
}
