using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueFrame : MonoBehaviour
{
    [SerializeField] private DialogueDatabase dialogueDatabase;
    [SerializeField] private Image characterImage;
    [SerializeField] private TMP_Text characterName;
    [SerializeField] private TMP_Text characterDialogueContent;

    private int currentIndex;

    private void OnEnable() {
        Init();
        ShowDialogue();
    }

    public void ShowDialogue() {
        if(currentIndex >= dialogueDatabase.Dialogue.Length) {
            HideDialogue();
            return;
        }

        characterImage.sprite = dialogueDatabase.Dialogue[currentIndex].characterImage;
        characterName.text = dialogueDatabase.Dialogue[currentIndex].characterName;
        characterDialogueContent.text = dialogueDatabase.Dialogue[currentIndex].characterDialogueContent;

        currentIndex++;
    }

    private void HideDialogue() {
        gameObject.SetActive(false);
    }

    private void Init() {
        currentIndex = 0;
    }
}
