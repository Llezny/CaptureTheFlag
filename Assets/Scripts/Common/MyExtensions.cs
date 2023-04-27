using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Common {
    public static class MyExtensions {
        public static T GetRandom<T>(this List<T> list) {
            return list[ Random.Range( 0, list.Count ) ];
        }

        public static string ToStopwatchFormat( this double timeInSeconds ) {
            return TimeSpan.FromSeconds( timeInSeconds ).ToString(@"mm\:ss\:fff");
        }
        
    }
}