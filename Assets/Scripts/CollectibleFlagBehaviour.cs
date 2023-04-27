using DefaultNamespace;
using UnityEngine;

public class CollectibleFlagBehaviour : CollectibleBehaviour {

    public override void Collect( ) {
        Debug.Log( "Collecting flag" );
        Hide( );
        base.Collect(  );
    }
    
    private void Hide( ) {
        this.gameObject.SetActive( false );
    }
}
