using DG.Tweening;
using UnityEngine;

namespace CaptureTheFlag.Player.Weapon {
    public class ScreenShakeOnShootBehaviour : MonoBehaviour {

        [ SerializeField ] private Camera mainCamera;
         [ SerializeField ] private GunBehaviour gunBehaviour;

        private void OnEnable( ) {
            gunBehaviour.onShoot += ShakeCamera;
        }

        private void OnDisable( ) {
            gunBehaviour.onShoot -= ShakeCamera;
        }

        private void ShakeCamera( ) {
            mainCamera.DOShakePosition( 0.15f, 0.15f, 50 );
        }
    }
}
