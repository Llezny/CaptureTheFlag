using System.Collections;
using System.Collections.Generic;
using SimpleDependencyInjection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishPopup : MonoBehaviour {

    [ InjectField ] private GameplayManager gameplayManager;
    [ InjectField ] private StopwatchBehaviour stopwatchBehaviour;
    
    [ SerializeField ] private TextMeshProUGUI titleText;
    [ SerializeField ] private TextMeshProUGUI timeText;
    [ SerializeField ] private Button restartButton; 
    [ SerializeField ] private Button quitButton; 

    
    
}
