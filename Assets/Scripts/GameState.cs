using System;
using System.Collections.Generic;

namespace DefaultNamespace {
    
    [Serializable]
    public class GameState {
        public List<LeaderboardRecord> leaderboards = new List<LeaderboardRecord>();
    }
    
}