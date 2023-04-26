using System;
using UnityEngine;
using UnityTemplateProjects;



public class PlayerHealthBehaviour : MonoBehaviour {


    public IStat<int> health = new Health( );

    private void Awake( ) {
        health.Set( 3 );
    }


    public void GetHit( ) {
        health.Decrease(  );
    }
}
       