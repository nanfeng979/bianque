using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum DayStatus {
    test = 9,
    Morning = 12,
    Noon = 13,
    Afternoon = 18,
    Evening = 19,
    Night = 22
}

enum testStatus {
    test1 = 9,
    test2 = 10,
    test3 = 11,
    test4 = 12,
    test5 = 13
}

public class oneDay : MonoBehaviour
{
    private int currentHour = 0;
    private float currentSecond = 0.0f;

    private Color[] DayStatusColor = new Color[]{
        new Color(1.0f, 0.0f, 0.0f, 1.0f),
        new Color(1.0f, 1.0f, 0.0f, 1.0f),
        new Color(0.0f, 1.0f, 0.0f, 1.0f),
        new Color(0.0f, 0.0f, 1.0f, 1.0f),
        new Color(1.0f, 0.0f, 1.0f, 1.0f),
    };

    private Image image;

    const int awake = 8 + 1;
    const int hour = 60 * 60;
    const int secondScale = hour / 4;

    void Start()
    {
        image = GetComponent<Image>();

        currentSecond = hourToSecond(awake);
    }

    void Update()
    {
        currentSecond += Time.deltaTime * secondScale;
        currentHour = secondToHour(currentSecond);
        
        // todo: 归位
        // if(currentHour > (int)DayStatus.Night) {
        //     // 准备睡觉
        // } else if(currentHour > (int)DayStatus.Evening) {
        //     // 准备上班
        // } else if(currentHour > (int)DayStatus.Afternoon) {
        //     // 准备上班
        // } else if(currentHour > (int)DayStatus.Noon) {
        //     // 准备上班
        // } else if(currentHour > (int)DayStatus.Morning) {
        //     // 准备上班
        // }

        if(currentHour > (int)testStatus.test5) {
            setImageColorLerp(DayStatusColor[4]);
        } else if(currentHour > (int)testStatus.test4) {
            setImageColorLerp(DayStatusColor[3]);
        } else if(currentHour > (int)testStatus.test3) {
            setImageColorLerp(DayStatusColor[2]);
        } else if(currentHour > (int)testStatus.test2) {
            setImageColorLerp(DayStatusColor[1]);
        } else if(currentHour > (int)testStatus.test1) {
            setImageColorLerp(DayStatusColor[0]);
        }

    }

    private void setImageColor(Color color) {
        image.color = color;
    }

    private void setImageColorLerp(Color color) {
        Color imagOldColor = image.color;
        image.color = Color.Lerp(imagOldColor, color, Time.deltaTime);
    }

    private int secondToHour(float second) {
        return (int)second / 3600;
    }

    private float hourToSecond(int hour) {
        return hour * 3600;
    }

}
