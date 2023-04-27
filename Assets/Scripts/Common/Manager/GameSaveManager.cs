using Common;
using DefaultNamespace;

public class GameSaveManager : PersistentSingleton<GameSaveManager> {

    private const string filePath = "CaptureTheFlag";
    private GameState gameState;
    public GameState GameState {
        get {
            if ( gameState == null ) {
                LoadGame(  );
            }
            return gameState;
        }
        private set {
            gameState = value;
        }
    }
    
    private void Start( ) {
        LoadGame(  );
    }

    private void LoadGame( ) {
        gameState = DataSaver.LoadData<GameState>( filePath );
    }

    public void SaveGame( ) {
        DataSaver.SaveData( gameState, filePath );
    }
}
