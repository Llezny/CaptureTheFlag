using System;
using System.Collections;
using System.Collections.Generic;
using SimpleDependencyInjection;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    [ SerializeField ] private GameObject content;

    private void OnEnable( ) {
       // inputReceiverBehaviour.
    }

    public void Open( ) {
        content.SetActive( true );
    }

    public void Close() {
        content.SetActive( false );
    }
    
    
}
