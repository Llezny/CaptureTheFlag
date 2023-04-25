using DG.Tweening;
using UnityEngine;

public class ScreenShakeOnShootBehaviour : MonoBehaviour {

    [ SerializeField ] private Camera mainCamera;
    [ SerializeField ] private ShootingBehaviour shootingBehaviour;

    private void OnEnable( ) {
        shootingBehaviour.onShoot += ShakeCamera;
    }

    private void OnDisable( ) {
        shootingBehaviour.onShoot -= ShakeCamera;
    }

    private void ShakeCamera( ) {
        mainCamera.DOShakePosition( 0.15f, 0.15f, 50 );
    }
}
