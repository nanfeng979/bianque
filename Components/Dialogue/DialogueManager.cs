using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public DialogueDatabase database;
    public TMP_Text _name;
    public TMP_Text context;
    public Text text;

    public int dialogueIndex = 0;

    void Start()
    {
        updateDialogueData(dialogueIndex);
    }

    void Update()
    {
        
    }

    private void updateDialogueData(int index) {
        _name.text = database.Dialogue[index].characterName;
        context.text = database.Dialogue[index].characterDialogueContent;
        text.text = database.Dialogue[index].characterDialogueContent;
    }

    public void OnClick() {
        dialogueIndex += 1;
        if(dialogueIndex >= database.Dialogue.Length) {
            dialogueIndex = 0;
            nextScene();
            return;
        }

        updateDialogueData(dialogueIndex);
    }

    private void nextScene() {
        SceneManager.LoadScene("Playing");
    }
}
