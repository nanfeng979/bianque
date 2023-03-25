using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class echoWorldTime : MonoBehaviour
{
    private TMP_Text text;

    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = "sinceTimeStart : " + Time.time.ToString();
    }
}
