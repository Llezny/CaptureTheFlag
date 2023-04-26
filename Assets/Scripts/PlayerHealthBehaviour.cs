using System;
using UnityEngine;
using UnityTemplateProjects;



public class PlayerHealthBehaviour : MonoBehaviour {

    public Action OnHit;
    public IStat<int> health = new Health( );

    private void Start( ) {
        health.Set( 3 );
    }

    public void GetHit( ) {
        health.Decrease(  );
        OnHit?.Invoke(  );
    }
}
       