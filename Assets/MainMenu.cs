using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [ SerializeField ] private Button startButton;
    [ SerializeField ] private Button leaderboardsButton;
    [ SerializeField ] private Button quitButton;

    private void OnEnable( ) {
        startButton.onClick.AddListener( StartGame );
        leaderboardsButton.onClick.AddListener( ShowLeaderboards );
        quitButton.onClick.AddListener( QuitGame );
    }

    private void OnDisable( ) {
        startButton.onClick.RemoveListener( StartGame );
        leaderboardsButton.onClick.RemoveListener( ShowLeaderboards );
        quitButton.onClick.RemoveListener( QuitGame );
    }

    private void StartGame( ) {
        SceneLoader.Instance.LoadScene( SceneName.Game );
    }

    private void ShowLeaderboards( ) {
        
    }

    private void QuitGame( ) {
        Application.Quit();
    }
}
