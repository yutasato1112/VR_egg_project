using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    int playTime;
    //残りプレイ時間
    int remainTime;

    // Start is called before the first frame update
    void Start()
    {
        bool boolOneMin = OneMin.selectOneMin;
        bool boolThreeMin = ThreeMin.selectThreeMin;
        bool boolFiveMin = FiveMin.selectFiveMin;
        bool boolTenMin = TenMin.selectTenMin;
        if (boolOneMin == true)
        {
            playTime = 1;
        }
        else if (boolThreeMin == true)
        {
            playTime = 3;
        }
        else if (boolFiveMin == true)
        {
            playTime = 5;
        }
        else if (boolTenMin == true)
        {
            playTime = 10;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        int playTimeSec = playTime * 60;
        remainTime = (int)(playTimeSec - Time.time);
        Debug.Log(remainTime);
    }
}
