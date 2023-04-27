using System;
using UnityEngine;

namespace DefaultNamespace {
    public abstract class CollectibleBehaviour : MonoBehaviour {
        public Action OnCollect { get; set; }
        public virtual void Collect( ) {
         OnCollect?.Invoke(  );   
        }
    }
}