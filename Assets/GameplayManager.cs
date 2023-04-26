using System.Collections;
using System.Collections.Generic;
using CaptureTheFlag.Common;
using UnityEngine;

public class GameplayManager : MonoBehaviour {
    
    public void PauseGame( ) {
        Time.timeScale = 0;
    }

    public void UnpauseGame( ) {
        Time.timeScale = 1;
    }
    
}
