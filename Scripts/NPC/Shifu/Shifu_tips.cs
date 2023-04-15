using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Shifu_tips : MonoBehaviour
{
    public GameObject dialogueUI;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(!dialogueUI.activeSelf) {
                ShowDialogueUI();
            }
        }
    }

    private void ShowDialogueUI() {
        dialogueUI.SetActive(true);
    }
}
