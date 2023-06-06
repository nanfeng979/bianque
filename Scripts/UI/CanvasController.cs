using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public GameObject tujian;
    public GameObject taskPanel;
    void Update() {
        if(Input.GetKeyDown((KeyCode)EShortcut.Tujian) ) {
            EnableTujian();
        }
    }
    public void EnableTujian() {
        tujian.SetActive(!tujian.activeSelf);
    }
    public void DisableTujian()
    {
        tujian.SetActive(false);
    }
    public void EnableTaskPanel()
    {
        taskPanel.SetActive(!taskPanel.activeSelf);
    }
}
