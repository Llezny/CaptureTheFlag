using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class CollectorBehaviour : MonoBehaviour  {
    private void OnTriggerEnter(Collider other) {
        if ( other.TryGetComponent<CollectibleBehaviour>( out var collectible ) ) {
            collectible.Collect(  );
        }
    }
}
