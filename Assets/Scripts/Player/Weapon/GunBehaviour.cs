using System;
using CaptureTheFlag.Common.Tool;
using CaptureTheFlag.Player.Movement;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CaptureTheFlag.Player.Weapon {
    public class GunBehaviour : MonoBehaviour, IGun {
    
        public Action onShoot;
        
        [ SerializeField ] private float shootingCooldown = 0.2f;

        private bool isShooting;
        private bool isInCooldown;
        private Timer cooldownTimer;

        private void Update( ) {
            cooldownTimer?.Tick( Time.deltaTime );
            Shoot( );
        }

        public void Shoot( ) {
            if ( !isShooting || isInCooldown ) {
                return;
            }
            onShoot?.Invoke();
        }
        
        private void OnEnable( ) {
            InputReceiverBehaviour.OnFirePressed += OnFirePressed;
            onShoot += SetupTimer;
        }

        private void OnDisable( ) {
            InputReceiverBehaviour.OnFirePressed -= OnFirePressed;
            onShoot -= SetupTimer;
        }

        private void OnFirePressed( InputValue inputValue ) {
            isShooting = inputValue.isPressed;
        }

        private void SetupTimer( ) {
            isInCooldown = true;
            cooldownTimer = new Timer( shootingCooldown, ( ) => isInCooldown = false );
        }
    }
}
