using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject puzzle;

    private bool canPlay = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(canPlay) {
            if(Input.GetKeyDown(KeyCode.Space)) {
                showPuzzle();
            }
        }
    }

    private void showPuzzle() {
        puzzle.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        canPlay = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        canPlay = false;
    }
}
