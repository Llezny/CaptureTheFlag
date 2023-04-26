using UnityEngine;
using Zombie;

namespace Player {
    public class ShootBehaviour : MonoBehaviour {

        [SerializeField] private GunBehaviour gunBehaviour;

        private void OnEnable( ) {
            gunBehaviour.onShoot += Shoot;
        }
    
        private void OnDisable( ) {
            gunBehaviour.onShoot -= Shoot;
        }

        private void Shoot( ) {
            if ( !Physics.Raycast( Camera.main.transform.position, Camera.main.transform.forward, out var hit ) ) {
                return;
            }

            if ( !hit.transform.TryGetComponent<IEnemy>( out var enemy ) ) {
                return;
            }
        
            enemy.GetHit();
        }
    }
}
