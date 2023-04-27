using System;
using System.Collections.Generic;

namespace CaptureTheFlag.Common {
    [Serializable]
    public class GameState {
        public List<LeaderboardRecord> leaderboards = new List<LeaderboardRecord>();
    }
}