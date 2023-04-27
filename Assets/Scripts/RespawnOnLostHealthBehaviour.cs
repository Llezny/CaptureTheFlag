using Player;
using UnityEngine;

public class RespawnOnLostHealthBehaviour : MonoBehaviour {
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private PlayerHealthBehaviour playerHealthBehaviour;

    private void OnEnable( ) {
        playerHealthBehaviour.OnHit += Respawn;
    }
    
    private void OnDisable( ) {
        playerHealthBehaviour.OnHit -= Respawn;
    }
    
    private void Respawn( ) {
        transform.position = respawnPoint.position;
    }
}
