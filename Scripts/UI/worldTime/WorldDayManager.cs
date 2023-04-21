using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldDayManager : MonoBehaviour
{
    public TMP_Text worldDayText;

    private int currentWorldDay = 35;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        worldDayText.text = currentWorldDay.ToString();
    }

    public void addWorldDay() {
        currentWorldDay++;
    }
}
