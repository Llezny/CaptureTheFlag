using PlayerStates;
using UnityEngine;

namespace Zombie {
    public class ZombieAttackingSMB : SceneLinkedSMB<ZombieBehaviour> {
   
        public override void OnSLStateEnter( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateEnter( animator, stateInfo, layerIndex );
            m_MonoBehaviour.AttackTarget();
            Debug.Log("idle");
        }
    }
}
