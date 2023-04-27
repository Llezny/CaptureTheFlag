using CaptureTheFlag._3rdParty.SimpleDependencyInjection;
using CaptureTheFlag.Collectible;
using UnityEngine;
using UnityEngine.UI;

namespace CaptureTheFlag.View {
    public class FlagUIBehaviour : MonoBehaviour {
    
        [InjectField] private FlagSystem flagSystem;
        [SerializeField] private Image flagIcon;

        private void OnEnable( ) {
            flagSystem.OnFlagCollect += ActivateFlagIcon;
        }

        private void OnDisable( ) {
            flagSystem.OnFlagCollect += ActivateFlagIcon;
        }

        private void ActivateFlagIcon( ) {
            flagIcon.color = Color.white;
        }
    }
}
