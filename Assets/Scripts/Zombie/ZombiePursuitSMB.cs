using PlayerStates;
using UnityEngine;

namespace Zombie {
    public class ZombiePursuitSMB : SceneLinkedSMB<ZombieBehaviour> {
    
        public override void OnSLStateEnter( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateEnter( animator, stateInfo, layerIndex );
        }
    
        public override void OnSLStateNoTransitionUpdate( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateNoTransitionUpdate( animator, stateInfo, layerIndex );
            m_MonoBehaviour.Pursuit( );
        }
    }
}
