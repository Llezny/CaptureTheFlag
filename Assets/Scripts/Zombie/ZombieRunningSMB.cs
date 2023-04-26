using PlayerStates;
using UnityEngine;

namespace Zombie {
    public class ZombieRunningSMB : SceneLinkedSMB<ZombieBehaviour> {

        public override void OnSLStateEnter( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateEnter( animator, stateInfo, layerIndex );
            Debug.Log("running");
        }

    
        public override void OnSLStateNoTransitionUpdate( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateNoTransitionUpdate( animator, stateInfo, layerIndex );
            m_MonoBehaviour.Running();
        }
    }
}
