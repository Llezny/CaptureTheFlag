using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.View;
using UnityEngine;

public class MainMenuButtonsUI : MenuBase {

    [SerializeField] private GameObject content;
    
    public override void ToggleMenu( bool enable ) {
        content.SetActive( enable );
    }

}
