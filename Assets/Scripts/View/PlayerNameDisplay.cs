using CaptureTheFlag.Common.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace CaptureTheFlag.View {
    public class PlayerNameDisplay : MonoBehaviour {

        [SerializeField] private StringSO playerName;
        [SerializeField] private Text playerNameText;

        private void Awake( ) {
            playerNameText.text = playerName.String;
        }
    }
}
