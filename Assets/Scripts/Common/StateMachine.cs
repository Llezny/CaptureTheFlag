using UnityEngine.Rendering;

namespace UnityTemplateProjects {
    public abstract class StateMachine {

        public StateMachine( State startState ) {
            this.SetState( startState );
        }
        
        protected State CurrentState;

        public virtual void Update(  ) { }

        public void SetState( State newState ) {
            if ( newState == null || newState == CurrentState ) {
                return;
            }
            CurrentState?.End();
            CurrentState = newState;
            CurrentState.Start();
        }
    }
}