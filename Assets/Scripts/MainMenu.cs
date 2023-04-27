using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using DefaultNamespace.View;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [ SerializeField ] private Button startButton;
    [ SerializeField ] private Button leaderboardsButton;
    [ SerializeField ] private Button quitButton;
    [ SerializeField ] private Button goBackToMenuButton;
    
    [ SerializeField ] private MenuBase mainMenu;
    [ SerializeField ] private MenuBase leaderBoards;

    private void OnEnable( ) {
        startButton.onClick.AddListener( StartGame );
        leaderboardsButton.onClick.AddListener( ShowLeaderboards );
        quitButton.onClick.AddListener( QuitGame );
        goBackToMenuButton.onClick.AddListener( ShowMainMenu );
    }

    private void OnDisable( ) {
        startButton.onClick.RemoveListener( StartGame );
        leaderboardsButton.onClick.RemoveListener( ShowLeaderboards );
        quitButton.onClick.RemoveListener( QuitGame );
        goBackToMenuButton.onClick.RemoveListener( ShowMainMenu );
    }

    private void StartGame( ) {
        SceneLoader.Instance.LoadScene( SceneName.Game );
    }

    private void ShowLeaderboards( ) {
        mainMenu.ToggleMenu( false );
        leaderBoards.ToggleMenu( true );
    }

    private void ShowMainMenu( ) {
        mainMenu.ToggleMenu( true );
        leaderBoards.ToggleMenu( false );
    }

    private void QuitGame( ) {
        Application.Quit();
    }
}
