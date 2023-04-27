using CaptureTheFlag.Common.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CaptureTheFlag.Common {
    public class PlayerNameListener : MonoBehaviour {
        [ SerializeField ] private StringSO playerNameSO;
        [ SerializeField ] private TMP_InputField inputField;

        public void Awake( ) {
            playerNameSO.String = string.Empty;
        }

        private void OnEnable( ) {
            inputField.onValueChanged.AddListener( UpdateString );
        }

        private void OnDisable( ) {
            inputField.onValueChanged.RemoveListener( UpdateString );
        }

        public void UpdateString( string str ) {
            playerNameSO.String = str;
        }
    }
}
