using System.Collections;
using System.Collections.Generic;
using Common;
using TMPro;
using UnityEngine;

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
