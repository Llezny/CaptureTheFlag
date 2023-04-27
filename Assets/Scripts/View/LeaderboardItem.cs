using CaptureTheFlag.Common.Tool;
using TMPro;
using UnityEngine;

namespace CaptureTheFlag.View {
    public class LeaderboardItem : MonoBehaviour {
    
        [SerializeField] private TextMeshProUGUI placeText;
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private TextMeshProUGUI timeText;

        public void Setup( int place, string name, double time ) {
            placeText.text = $"{place}.";
            nameText.text = name;
            timeText.text = time.ToStopwatchFormat(  );
        }
    }
}
