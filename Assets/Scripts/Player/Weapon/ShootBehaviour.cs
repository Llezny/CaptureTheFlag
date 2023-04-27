using CaptureTheFlag.Zombie;
using UnityEngine;

namespace CaptureTheFlag.Player.Weapon {
    public class ShootBehaviour : MonoBehaviour {

        [ SerializeField ] private GunBehaviour gunBehaviour;
        [ SerializeField ] private Transform mainCameraTransform;

        private void Start( ) {
            mainCameraTransform = Camera.main.transform;
        }

        private void OnEnable( ) {
            gunBehaviour.onShoot += Shoot;
        }
    
        private void OnDisable( ) {
            gunBehaviour.onShoot -= Shoot;
        }

        private void Shoot( ) {
            if ( !Physics.Raycast( mainCameraTransform.position, mainCameraTransform.forward, out var hit ) ) {
                return;
            }
            if ( !hit.transform.TryGetComponent<IEnemy>( out var enemy ) ) {
                return;
            }
        
            enemy.GetHit();
        }
    }
}
