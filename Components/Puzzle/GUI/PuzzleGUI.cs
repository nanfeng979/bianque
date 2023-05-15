using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PuzzleGUI : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject Puzzle;

    private Color oldColor;
    private Color newColor;
    private string oldString;
    private string newString = "新草药\n已到达";

    private bool flag = false;

    void Start()
    {
        oldColor = text.color;
        newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 1);
        oldString = text.text;

        Invoke("newCaoyao", 2.0f);
    }

    void Update()
    {
        
    }

    private void newCaoyao() {
        text.color = newColor;
        text.text = newString;

        flag = true;
    }

    public void OnClick() {
        if(!flag) {
            return;
        }

        Puzzle.SetActive(true);

        text.color = oldColor;
        text.text = oldString;

        flag = false;
        Invoke("newCaoyao", 3.0f);
    }
}
