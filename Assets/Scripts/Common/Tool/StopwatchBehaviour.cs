using CaptureTheFlag.Common.Manager;
using UnityEngine;

namespace CaptureTheFlag.Common.Tool {
    public class StopwatchBehaviour : MonoBehaviour {

        public readonly Stopwatch Stopwatch = new Stopwatch( );
    
        private void OnEnable( ) {
            GameplayManager.OnGameFinish.AddListener( Stopwatch.FinishCounting );
        }

        private void OnDisable( ) {
            GameplayManager.OnGameFinish.RemoveListener( Stopwatch.FinishCounting );
        }

        private void Update( ) {
            Stopwatch.Tick( Time.deltaTime );
        }
    }
}
