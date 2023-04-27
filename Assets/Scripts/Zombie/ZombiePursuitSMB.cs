using CaptureTheFlag._3rdParty;
using UnityEngine;

namespace CaptureTheFlag.Zombie {
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
