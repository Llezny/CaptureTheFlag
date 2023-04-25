using Common;
using UnityEngine;

public class ZombieIdleSMB : SceneLinkedSMB<ZombieBehaviour> {

    
    public override void OnSLStateEnter( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
        base.OnSLStateEnter( animator, stateInfo, layerIndex );
        Debug.Log("idle");
    }
    
    public override void OnSLStateNoTransitionUpdate( Animator animator, AnimatorStateInfo stateInfo, int layerIndex ) {
        base.OnSLStateNoTransitionUpdate( animator, stateInfo, layerIndex );
        if ( m_MonoBehaviour.FindTarget( out var target ) ) {
            m_MonoBehaviour.StartPursuit( target.transform );
        }
        else {
            m_MonoBehaviour.StartWandering( );
        }
    }
}
