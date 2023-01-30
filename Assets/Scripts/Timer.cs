using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime = 121f;

    void Start()
    {
        // startTime = Time.time;
    }

    void Update()
    {
        int t = (int)(startTime - Time.time);

        string minutes = ((int)t / 60).ToString();
        float secI = (t % 60);
        string seconds = "";
        if (secI < 10)
        {
            seconds = "0";
        }
        seconds += (t % 60).ToString("f0");
        timerText.text = minutes + ":" + seconds;

        if (t <= 0)
        {
            Debug.Log("out of time");
            Time.timeScale = 0f;
            //activate defeat screen
        }
    }
}
