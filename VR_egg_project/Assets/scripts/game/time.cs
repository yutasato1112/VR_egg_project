using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class time : MonoBehaviour
{

    public TextMeshProUGUI timeDisplay;

    //ユーザの設定したプレイ時間
    int playTime;
    //残りプレイ時間
    int remainTime;

    // Start is called before the first frame update
    void Start()
    {
        playTime = userSelectTime.selectTime;
    }

    // Update is called once per frame
    void Update()
    {
        int playTimeSec = playTime * 60;
        remainTime = (int)(playTimeSec - Time.time);
        timeDisplay.text = string.Format("{0}",remainTime);
    }
}
