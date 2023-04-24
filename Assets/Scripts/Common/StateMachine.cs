using UnityEngine.Rendering;

namespace UnityTemplateProjects {
    public abstract class StateMachine {
        
        protected State CurrentState;

        public void SetState( State newState ) {
            CurrentState.End();
            CurrentState = newState;
            CurrentState.Start();
        }
    }
}