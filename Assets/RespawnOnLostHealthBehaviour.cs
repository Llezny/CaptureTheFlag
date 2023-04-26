using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

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
