using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyDebug : MonoBehaviour
{
    public TMP_Text gameStatus;
    public TMP_Text worldDate;

    void Update()
    {
        gameStatus.text = "current gameStatus : " + GameManager.instance.GetStatus().ToString();
        worldDate.text = "sinceTimeStart : " + Time.time.ToString();
    }

}
