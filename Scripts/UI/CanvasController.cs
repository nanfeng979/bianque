using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public GameObject tujian;

    void Update() {
        if(Input.GetKeyDown(KeyCode.T)) {
            EnableTujian();
        }
    }

    private void EnableTujian() {
        tujian.SetActive(true);
    }

    
}
