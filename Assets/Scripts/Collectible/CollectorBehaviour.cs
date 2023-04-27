using UnityEngine;

namespace CaptureTheFlag.Collectible {
    public class CollectorBehaviour : MonoBehaviour  {
        private void OnTriggerEnter(Collider other) {
            if ( other.TryGetComponent<CollectibleBehaviour>( out var collectible ) ) {
                collectible.Collect(  );
            }
        }
    }
}
