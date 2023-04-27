using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using SimpleDependencyInjection;
using UnityEngine;
using UnityEngine.UI;

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
