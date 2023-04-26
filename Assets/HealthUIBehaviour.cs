using System;
using System.Collections.Generic;
using SimpleDependencyInjection;
using UnityEngine;

public class HealthUIBehaviour : MonoBehaviour {
    
    [InjectField] private PlayerHealthBehaviour playerHealthBehaviour;
    
    [SerializeField] private GameObject heartPrefab;
    [SerializeField] private Transform heartsHolder;
    
    private List<GameObject> spawnedHearts = new List<GameObject>();
    
    private void OnEnable( ) {
        playerHealthBehaviour.health.OnChangeEvent.AddListener( UpdateUI );
    }

    private void OnDisable( ) {
        playerHealthBehaviour.health.OnChangeEvent.RemoveListener( UpdateUI );
    }
    
    private void UpdateUI( int val ) {
        if (  spawnedHearts.Count == 0 ) {
            SpawnHearts( val );
        }

        for ( int i = 0; i < spawnedHearts.Count; i++ ) {
            spawnedHearts[i].SetActive( i < val );
        }
    }

    private void SpawnHearts( int num ) {
        for ( int i = 0; i < num; i++ ) {
            spawnedHearts.Add( Instantiate( heartPrefab, heartsHolder ) );
        }
    }
    
}
