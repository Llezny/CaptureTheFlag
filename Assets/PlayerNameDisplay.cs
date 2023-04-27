using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour {

    [SerializeField] private StringSO playerName;
    [SerializeField] private Text playerNameText;

    private void Awake( ) {
        playerNameText.text = playerName.String;
    }
}
