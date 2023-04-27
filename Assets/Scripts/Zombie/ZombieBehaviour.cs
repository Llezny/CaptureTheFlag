using System.Collections.Generic;
using System.Linq;
using Player;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

namespace Zombie {
    public class ZombieBehaviour : MonoBehaviour, IEnemy {

        public static int isWalkingHash = Animator.StringToHash( "isWalking" );
        public static int isRunningHash = Animator.StringToHash( "isRunning" );
        public static int inPursuitHash = Animator.StringToHash( "inPursuit" );
        public static int attackHash = Animator.StringToHash( "isAttacking" );
        public static int dieHash = Animator.StringToHash( "die" );
    
        [ SerializeField ] private Animator animator;
        [ SerializeField ] private NavMeshAgent navMeshAgent;
    
        private float maxDistanceToPursuit = 20f;
        private float maxDistanceToRun = 10f;
        private float maxDistanceToAttack = 3f;
        public float DistanceToPlayer => Vector3.Distance( target.position, transform.position );
    
        private Transform target;
        private List<GameObject> players;
    
        private void OnEnable( ) {
            GetPlayersList( );
            ZombieIdleSMB.Initialise( animator, this );
        }

        public void GetHit( ) {
            animator.SetTrigger( dieHash );
        }

        public void Running( ) {
            GoTowardsTarget( );
            if ( navMeshAgent.remainingDistance > maxDistanceToRun ) {
                animator.SetBool( isRunningHash, false );
            }

            if ( navMeshAgent.remainingDistance < maxDistanceToAttack ) {
                animator.SetTrigger( attackHash );
            }
        }

        public void Die( ) {
            this.gameObject.AddComponent<DespawnAfterTime>( );
        }

        public bool FindTarget( out GameObject target ) {
            if ( players == null || players.Count == 0 ) {
                GetPlayersList( );
            }

            target = null;
            bool foundTarget = false;
            var minDistance = float.MaxValue;
        
            foreach ( var player in players  ) {
                var distance = Vector3.Distance( player.transform.position, transform.position );
                if ( distance > minDistance || distance > maxDistanceToPursuit ) {
                    continue;
                }
                minDistance = distance;
                target = player;
                foundTarget = true;
            }
            return foundTarget;
        }

        public void StartPursuit( Transform target ) {
            this.target = target;
            animator.SetBool( inPursuitHash, true );
        }

        public void Pursuit( ) {
            GoTowardsTarget( );
            if ( navMeshAgent.remainingDistance > maxDistanceToPursuit ) {
                animator.SetBool( inPursuitHash, false );
            }
            if ( navMeshAgent.remainingDistance < maxDistanceToRun ) {
                animator.SetBool( isRunningHash, true );
            }
        }

        private void GoTowardsTarget( ) {
            navMeshAgent.destination = target.position;
            navMeshAgent.transform.rotation.SetLookRotation( Vector3.forward );
        }

        public void StartWandering( ) {
            animator.SetBool( isWalkingHash, true );
            if ( TryGetRandomPoint( transform.position, 3, out var result) ) {
                navMeshAgent.destination = result;
            }
        }
    
        bool TryGetRandomPoint(Vector3 center, float range, out Vector3 result) {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            if (NavMesh.SamplePosition(randomPoint, out var hit, 1.0f, NavMesh.AllAreas)) {
                result = hit.position;
                return true;
            }

            result = Vector3.zero;
            return false;
        }
    
        private void GetPlayersList( ) {
            players = GameObject.FindGameObjectsWithTag( "Player" ).ToList();
        }

        public void AttackTarget( ) {
            if ( target.TryGetComponent<PlayerHealthBehaviour>( out var playerHealth ) ) {
                playerHealth.GetHit();
            }
        }

    }
}
