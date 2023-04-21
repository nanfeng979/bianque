using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldDayManager : MonoBehaviour
{
    // public TMP_Text worldDayText;
    [SerializeField] private Image firstNumber;
    [SerializeField] private Image secondNumber;

    [SerializeField] private List<Sprite> sprites;

    private int currentWorldDay = 35;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // worldDayText.text = currentWorldDay.ToString();

        int firstNum = currentWorldDay / 10;
        int secondNum = currentWorldDay % 10;
        firstNumber.sprite = sprites[firstNum];
        secondNumber.sprite = sprites[secondNum];
    }

    public void addWorldDay() {
        currentWorldDay++;
    }
}
