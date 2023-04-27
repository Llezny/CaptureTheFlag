using System.Collections.Generic;
using CaptureTheFlag.Common.Manager;
using CaptureTheFlag.Common.ScriptableObjects;
using CaptureTheFlag.Common.Tool;
using UnityEngine;

namespace CaptureTheFlag.Common {
    public class LeaderboardsHandlerBehaviour : MonoBehaviour {

        public const int MaxLeaderboardLength = 10;
    
        [ SerializeField ] private StopwatchBehaviour stopwatch;
        [ SerializeField ] private StringSO playerName;
    
        private List<LeaderboardRecord> leaderboards;
        public List<LeaderboardRecord> Leaderboards {
            get {
                if ( leaderboards == null ) {
                    leaderboards = GameSaveManager.Instance.GameState.leaderboards;
                }
                return leaderboards;
            }
            private set => leaderboards = value;
        }

        private void OnEnable( ) {
            stopwatch.Stopwatch.OnCountingFinish += SaveResultIfWorth;
        }

        private void OnDisable( ) {
            stopwatch.Stopwatch.OnCountingFinish -= SaveResultIfWorth;
        }

        private void SaveResultIfWorth( double result, bool won ) {
            if ( !won ) {
                return;
            }
            Leaderboards.Add( new LeaderboardRecord( playerName.String, result ) );
            Leaderboards.Sort();
            if ( Leaderboards.Count > MaxLeaderboardLength ) {
                Leaderboards.RemoveRange( MaxLeaderboardLength -1,  Leaderboards.Count - MaxLeaderboardLength );
            }
            GameSaveManager.Instance.SaveGame(  );
        }
    }
}
