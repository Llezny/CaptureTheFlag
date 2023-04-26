using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
    public class GunBehaviour : MonoBehaviour {
    
        public Action onShoot;
    
        [ SerializeField ] private Transform bulletSpawnPoint;
        private bool isShooting;
        private bool isWaitingForNextFire;
        private Common.Timer cooldownTimer;

        private void Update( ) {
            cooldownTimer?.Tick( Time.deltaTime );
            if ( !isShooting || isWaitingForNextFire) {
                return;
            }
            onShoot?.Invoke();
        }


        private void OnEnable( ) {
            InputReceiverBehaviour.OnFirePressed += Shoot;
            onShoot += SetupTimer;
        }

        private void OnDisable( ) {
            InputReceiverBehaviour.OnFirePressed -= Shoot;
            onShoot -= SetupTimer;
        }

        private void Shoot( InputValue inputValue ) {
            isShooting = inputValue.isPressed;
        }

        private void SetupTimer( ) {
            isWaitingForNextFire = true;
            cooldownTimer = new Common.Timer( 0.2f, ( ) => isWaitingForNextFire = false );
        }
    }
}
