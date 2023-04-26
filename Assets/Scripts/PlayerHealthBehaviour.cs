using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTemplateProjects.ScriptableObjects;


public class PlayerHealthBehaviour : MonoBehaviour {

    public GameEvent healthDecreasedEvent;

    public void GetHit( ) {
        healthDecreasedEvent.Raise(  );
    }
}
       