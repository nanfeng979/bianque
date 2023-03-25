using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class echoGameStatus : MonoBehaviour
{
    private TMP_Text text;

    private void Start() {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = "current gameStatus : " + GameManager.instance.GetStatus().ToString();
    }
}
