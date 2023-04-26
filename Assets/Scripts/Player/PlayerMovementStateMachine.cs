using Common;

namespace Player {
    public class PlayerMovementStateMachine : StateMachine {

        private PlayerMovementBehaviour playerMovementBehaviour;
        public PlayerMovementStateMachine( State startState, PlayerMovementBehaviour playerMovementBehaviour ) : base( startState ) {
            this.playerMovementBehaviour = playerMovementBehaviour;
        }

        public override void Update( ) {
            CurrentState.Update();
        }
        
    }
}