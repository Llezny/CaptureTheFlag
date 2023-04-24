using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Common {
    public static class ListExtensions {
        public static T GetRandom<T>(this List<T> list) {
            return list[ Random.Range( 0, list.Count ) ];
        }
    }
}