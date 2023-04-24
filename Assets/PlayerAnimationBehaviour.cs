using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationBehaviour : MonoBehaviour {
   
   public static readonly int WalkSpeedHash = Animator.StringToHash( "walkSpeed" );
   public static readonly int IsRunningHash = Animator.StringToHash( "isRunning" );
   
   [ SerializeField ] private Animator animator;
   [ SerializeField ] private InputReceiverBehaviour inputReceiverBehaviour;
   
   private void OnEnable( ) {
      AddListeners( );
   }
    
   private void OnDisable( ) {
      RemoveListeners( );
   }
   
   private void AddListeners( ) {
      inputReceiverBehaviour.OnMovePressed += Move;
      inputReceiverBehaviour.OnRunPressed += Run;
      inputReceiverBehaviour.OnJumpPressed += Jump;
   }

   private void RemoveListeners( ) {
      inputReceiverBehaviour.OnMovePressed -= Move;
      inputReceiverBehaviour.OnRunPressed -= Run;
      inputReceiverBehaviour.OnJumpPressed -= Jump;
   }
   
   private void Move( InputValue inputValue ) {
      var inputVector = inputValue.Get<Vector2>( );
      animator.SetFloat( WalkSpeedHash, inputVector.magnitude );
   }
  
   private void Run( InputValue inputValue ) {
      animator.SetBool( IsRunningHash, inputValue.isPressed );
   }
  
   private void Jump( InputValue inputValue ) {

   }

}
