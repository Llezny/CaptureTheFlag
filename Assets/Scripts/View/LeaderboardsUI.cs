using CaptureTheFlag.Common;
using CaptureTheFlag.Common.Manager;
using UnityEngine;

namespace CaptureTheFlag.View {
    public class LeaderboardsUI : MenuBase {

        [SerializeField] private GameObject content;
        [SerializeField] private Transform leaderBoardItemsHolder;
        [SerializeField] private LeaderboardItem leaderboardPrefab;
    
        private GameState gameState;

        private void Start( ) {
            gameState = GameSaveManager.Instance.GameState;
            for(int i = 0; i < gameState.leaderboards.Count; i++ ) {
                var leaderboardItem = Instantiate( leaderboardPrefab, leaderBoardItemsHolder );
                leaderboardItem.Setup( i, gameState.leaderboards[i].name, gameState.leaderboards[i].time  );
            }
        }

        public override void ToggleMenu( bool enable ) {
            content.SetActive( enable );
        }
    }
}
