using PlayerStates;
using UnityEngine;

namespace Zombie {
    public class ZombieWanderingSMB : SceneLinkedSMB<ZombieBehaviour> {
        public override void OnSLStateNoTransitionUpdate( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateNoTransitionUpdate( animator, stateInfo, layerIndex );
            if ( m_MonoBehaviour.FindTarget( out var target ) ) {
                m_MonoBehaviour.StartPursuit( target.transform );
            }
        }
    }
}