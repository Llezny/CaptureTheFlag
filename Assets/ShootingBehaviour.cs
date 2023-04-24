using System;
using System.Timers;
using Common;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingBehaviour : MonoBehaviour {
    
    public Action onShoot;
    
    [ SerializeField ] private InputReceiverBehaviour inputReceiverBehaviour;
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
        inputReceiverBehaviour.OnFirePressed += Shoot;
        onShoot += SetupTimer;
    }

    private void OnDisable( ) {
        inputReceiverBehaviour.OnFirePressed -= Shoot;
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
