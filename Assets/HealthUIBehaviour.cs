using System;
using SimpleDependencyInjection;
using UnityEngine;

public class HealthUIBehaviour : MonoBehaviour {
    
    [InjectField] private PlayerHealthBehaviour playerHealthBehaviour;


    private void OnEnable( ) {
        playerHealthBehaviour.health.OnChangeEvent.AddListener( UpdateUI );
    }

    private void OnDisable( ) {
        playerHealthBehaviour.health.OnChangeEvent.RemoveListener( UpdateUI );
    }

    public void UpdateUI( int val ) {
        Debug.Log( "Update UI" );
    }
}
