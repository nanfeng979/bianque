using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountdown : MonoBehaviour
{
    public Text countdownText;
    private int countdownSeconds = 10;
    public GameObject puzzle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator StartCountdown()
    {
        while (countdownSeconds > 0)
        {
            countdownText.text = countdownSeconds.ToString();

            yield return new WaitForSeconds(1f);
            countdownSeconds--;
        }

        puzzle.SetActive(false);
    }
}
