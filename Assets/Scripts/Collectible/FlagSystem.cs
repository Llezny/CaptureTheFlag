using System;
using CaptureTheFlag.Common.Manager;
using UnityEngine;

namespace CaptureTheFlag.Collectible {
    public class FlagSystem : MonoBehaviour {
    
        [ SerializeField ] private CollectibleBehaviour flag;
        [ SerializeField ] private CollectibleBehaviour startPoint;
    
        private bool isFlagCollected;
        public Action OnFlagCollect {
            get => flag.OnCollect;
            set => flag.OnCollect = value;
        }

        private void OnEnable( ) {
            flag.OnCollect += FlagCollect;
            startPoint.OnCollect += ReturnToBase;
        }
    
        private void OnDisable( ) {
            flag.OnCollect += FlagCollect;
            startPoint.OnCollect += ReturnToBase;
        }

        private void FlagCollect( ) {
            isFlagCollected = true;
        }

        private void ReturnToBase( ) {
            if ( isFlagCollected ) {
                GameplayManager.WinGame();
            }
        }
    }
}
