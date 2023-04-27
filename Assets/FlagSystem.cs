using DefaultNamespace;
using UnityEngine;

public class FlagSystem : MonoBehaviour {
    
    [SerializeField] private CollectibleBehaviour flag;
    [SerializeField] private CollectibleBehaviour startPoint;
    
    private bool isFlagCollected;
    
    private void OnEnable( ) {
        flag.OnCollect += FlagCollect;
        startPoint.OnCollect += ReturnToBase;
    }
    
    private void OnDisable( ) {
        flag.OnCollect += FlagCollect;
        startPoint.OnCollect += ReturnToBase;
    }

    private void FlagCollect( ) {
        isFlagCollected = true;
    }

    private void ReturnToBase( ) {
        if ( isFlagCollected ) {
            Debug.Log( "Wingame" );
        }
    }
}
