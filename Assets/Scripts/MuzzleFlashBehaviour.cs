using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using UnityEngine.Serialization;

public class MuzzleFlashBehaviour : MonoBehaviour {
    
    [FormerlySerializedAs( "shootingBehaviour" )] [ SerializeField ] private GunBehaviour gunBehaviour;
    [ SerializeField ] private Transform flashParent;
    [ SerializeField ] private List<GameObject> flashPrefabs;


    private void OnEnable( ) {
        gunBehaviour.onShoot += ShowFlash;
    }
    
    private void OnDisable( ) {
        gunBehaviour.onShoot -= ShowFlash;
    }

    private void ShowFlash( ) {
        Instantiate( flashPrefabs.GetRandom( ),  flashParent.position, flashParent.rotation * Quaternion.Euler( 0, 0, 90 ), flashParent );
    }
}
