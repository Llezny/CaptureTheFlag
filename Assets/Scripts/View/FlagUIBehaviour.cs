using SimpleDependencyInjection;
using UnityEngine;
using UnityEngine.UI;

public class FlagUIBehaviour : MonoBehaviour {
    
    [InjectField] private FlagSystem flagSystem;
    [SerializeField] private Image flagIcon;

    private void OnEnable( ) {
        flagSystem.OnFlagCollect += ActivateFlagIcon;
    }

    private void OnDisable( ) {
        flagSystem.OnFlagCollect += ActivateFlagIcon;
    }

    private void ActivateFlagIcon( ) {
        flagIcon.color = Color.white;
    }
}
