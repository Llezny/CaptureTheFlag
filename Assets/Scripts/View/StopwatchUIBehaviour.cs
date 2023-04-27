using CaptureTheFlag._3rdParty.SimpleDependencyInjection;
using CaptureTheFlag.Common.Tool;
using UnityEngine;
using UnityEngine.UI;

namespace CaptureTheFlag.View {
    public class StopwatchUIBehaviour : MonoBehaviour {
    
        [InjectField] private StopwatchBehaviour stopwatchBehaviour;
    
        [ SerializeField ] private Text stopwatchText;

        private void OnEnable( ) {
            stopwatchBehaviour.Stopwatch.TickCallback += UpdateUI;
        }

        private void OnDisable( ) {
            stopwatchBehaviour.Stopwatch.TickCallback -= UpdateUI;
        }
    
        private void UpdateUI( double elapsedTime ) {
            stopwatchText.text = elapsedTime.ToStopwatchFormat( );
        }
    }
}
