using CaptureTheFlag._3rdParty;
using UnityEngine;

namespace CaptureTheFlag.Zombie {
    public class ZombieAttackingSMB : SceneLinkedSMB<ZombieBehaviour> {
   
        public override void OnSLStateEnter( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateEnter( animator, stateInfo, layerIndex );
            m_MonoBehaviour.AttackTarget();
        }
    }
}
