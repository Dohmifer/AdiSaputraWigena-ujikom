using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timeText;
    public float maxTime;
    public float time;
    bool startTimer;

    void Start()
    {

        StartTimer();

    }

    // Update is called once per frame
    void Update()
    {
        if (!startTimer) return;

        if (time > 0f)
        {
            time -= Time.deltaTime;
            timeText.text = Mathf.CeilToInt(time).ToString();
        }
    }

    public void StartTimer()
    {
        time = maxTime;
        timeText.text = time.ToString();
        startTimer = true;
    }

    public void StopTimer()
    {

    }
}
