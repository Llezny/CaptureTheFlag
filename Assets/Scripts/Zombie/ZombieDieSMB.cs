using CaptureTheFlag._3rdParty;
using UnityEngine;

namespace CaptureTheFlag.Zombie {
    public class ZombieDieSMB : SceneLinkedSMB<ZombieBehaviour> {
        public override void OnSLStateExit( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
            base.OnSLStateEnter( animator, stateInfo, layerIndex );
            m_MonoBehaviour.Die(  );
        }
    }
}