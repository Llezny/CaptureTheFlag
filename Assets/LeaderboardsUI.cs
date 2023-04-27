using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using DefaultNamespace;
using DefaultNamespace.View;
using Lean.Common;
using UnityEngine;

public class LeaderboardsUI : MonoBehaviour, IMenu {

    [SerializeField] private GameObject content;
    [SerializeField] private LeaderboardItem leaderboardPrefab;
    
    private GameState gameState;

    private void Start( ) {
        gameState = GameSaveManager.Instance.GameState;
        for(int i = 0; i < gameState.leaderboards.Count; i++ ) {
           var leaderboardItem = Instantiate( leaderboardPrefab, content.transform );
           leaderboardItem.Setup( i, gameState.leaderboards[i].name, gameState.leaderboards[i].time  );
        }
    }

    public void ToggleMenu( bool enable ) {
        content.SetActive( enable );
    }
    
    
}
