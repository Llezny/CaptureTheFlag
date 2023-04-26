using System;
using UnityEngine;
using UnityTemplateProjects;
using UnityTemplateProjects.ScriptableObjects;


public class PlayerHealthBehaviour : MonoBehaviour {

    public GameEvent healthDecreasedEvent;
    public IStat<int> health;

    private void OnEnable( ) {
        health.OnChangeEvent.AddListener( healthDecreasedEvent.Raise( 2 ) );
    }

    public void GetHit( ) {
        
    }
}
       