using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
   public class PlayerAnimationBehaviour : MonoBehaviour {
   
      public static readonly int WalkSpeedHash = Animator.StringToHash( "walkSpeed" );
      public static readonly int IsRunningHash = Animator.StringToHash( "isRunning" );
   
      [ SerializeField ] private Animator animator;

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
}
