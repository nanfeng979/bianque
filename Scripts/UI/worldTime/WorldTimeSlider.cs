using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldTimeSlider : MonoBehaviour
{
    private RectTransform rect;

    private float timeSpeed;

    void Start() {
        rect = GetComponent<RectTransform>();
        timeSpeed = 20.0f;
    }

    void Update() {
        // 得到rect的top
        float top = rect.offsetMax.y;
        top += timeSpeed * Time.deltaTime;
        if(top >= 00.0f) {
            top = -100.0f;
            addWorldDay();
        }

        rect.offsetMax = new Vector2(rect.offsetMax.x, top);
        
    }

    private void addWorldDay() {
        Debug.Log("加一天");
    }
}
