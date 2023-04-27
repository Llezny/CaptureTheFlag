using UnityEngine;

namespace ScriptableObjects {
    
    [CreateAssetMenu(fileName = "StringSO", menuName = "ScriptableObjects/PrimitiveTypes/String", order = 1)]
    public class StringSO : ScriptableObject {
        [field:SerializeField]
        public string String { get; set; }
    }
}