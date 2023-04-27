using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using DefaultNamespace.View;
using SimpleDependencyInjection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishPopup : MonoBehaviour, IMenu {

    [ InjectField ] private GameplayManager gameplayManager;
    [ InjectField ] private StopwatchBehaviour stopwatchBehaviour;
    
    
    [ SerializeField ] private GameObject content;
    [ SerializeField ] private TextMeshProUGUI titleText;
    [ SerializeField ] private TextMeshProUGUI timeText;
    
    private const string titleOnLose = "You lose";
    private const string titleOnWin = "You win";

    private void OnEnable( ) {
        GameplayManager.OnGameFinish.AddListener( ShowMenu );
    }
    
    private void OnDisable( ) {
        GameplayManager.OnGameFinish.RemoveListener( ShowMenu );
    }

    public void ToggleMenu( bool enable ) {
        content.SetActive( enable );
    }

    public void ShowMenu( bool won ) {
        ToggleMenu( true );
        titleText.text = won ? titleOnWin : titleOnLose;
        if ( won ) {
            timeText.gameObject.SetActive( true );
            timeText.text = stopwatchBehaviour.Stopwatch.ElapsedSeconds.ToStopwatchFormat( );
        }

    }

    
}