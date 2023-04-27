using System;
using UnityEngine;

namespace DefaultNamespace {
    
    [Serializable]
    public class LeaderboardRecord : IComparable<LeaderboardRecord> {
        
        public string name;
        public double time;
        
        public LeaderboardRecord( string name, double time ) {
            this.name = name;
            this.time = time;
        }
        
        public int CompareTo( LeaderboardRecord other ) {
            return time.CompareTo( other.time );
        }
    }
}