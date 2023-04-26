using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using Timer = System.Timers.Timer;

public class StopwatchBehaviour : MonoBehaviour {

    public readonly Stopwatch Stopwatch = new Stopwatch( );
    
    private void Update( ) {
        Stopwatch.Tick( Time.deltaTime );
    }
}
