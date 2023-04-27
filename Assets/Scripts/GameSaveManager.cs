using System.Collections;
using System.Collections.Generic;
using Common;
using DefaultNamespace;
using UnityEngine;

public class GameSaveManager : PersistentSingleton<MonoBehaviour> {

    private const string filePath = "CaptureTheFlag";
    public GameState GameState { get; private set; }

    protected override void Awake( ) {
        base.Awake( );
        LoadGame( );
    }

    public void LoadGame( ) {
        GameState = DataSaver.LoadData<GameState>( filePath );
    }

    public void SaveGame( ) {
        DataSaver.SaveData( GameState, filePath );
    }
}
