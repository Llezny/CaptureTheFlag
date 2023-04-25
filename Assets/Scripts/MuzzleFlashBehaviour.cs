using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using UnityEngine.Serialization;

public class MuzzleFlashBehaviour : MonoBehaviour {
    
    [ SerializeField ] private ShootingBehaviour shootingBehaviour;
    [ SerializeField ] private Transform flashParent;
    [ SerializeField ] private List<GameObject> flashPrefabs;


    private void OnEnable( ) {
        shootingBehaviour.onShoot += ShowFlash;
    }
    
    private void OnDisable( ) {
        shootingBehaviour.onShoot -= ShowFlash;
    }

    private void ShowFlash( ) {
        Instantiate( flashPrefabs.GetRandom( ),  flashParent.position, flashParent.rotation * Quaternion.Euler( 0, 0, 90 ), flashParent );
    }
}
