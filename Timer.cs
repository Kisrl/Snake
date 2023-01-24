using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 0;
    public TextMeshProUGUI TimerText;

    void Start()
    {
        TimerText.text = timeStart.ToString("F2");
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        TimerText.text = timeStart.ToString("F2");
    }
}
