using System;
using UnityEngine;
using TMPro;

public class ClockController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI TimeText;

    [SerializeField]
    TextMeshProUGUI DateText;

    string[] week = new string[7]
    {
        "Sun",
        "Mon",
        "Tue",
        "Wed",
        "Thu",
        "Fri",
        "Sut"
    };

    void FixedUpdate()
    {
        if (TimeText.text != DateTime.Now.ToShortTimeString())
        {
            TimeText.text = DateTime.Now.ToShortTimeString();
        }
        if (DateText.text != DateTime.Now.ToString("yyyy/MM/dd/") + week[(int)DateTime.Now.DayOfWeek])
        {
            DateText.text = DateTime.Now.ToString("yyyy/MM/dd/") + week[(int)DateTime.Now.DayOfWeek];
        }
    }
    public void CloseClock()
    {
        Application.Quit();
    }
}