using System;
using UnityEngine;

namespace CaptureTheFlag.Collectible {
    public abstract class CollectibleBehaviour : MonoBehaviour {
        public Action OnCollect { get; set; }
        public virtual void Collect( ) {
         OnCollect?.Invoke(  );   
        }
    }
}