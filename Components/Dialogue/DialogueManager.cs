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

    public Image Lihui;
    public Transform LeftPosition;
    public Transform RightPosition;

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

        updateImage(index);
    }

    private void updateImage(int index) {
        Lihui.gameObject.SetActive(false);
        if(database.Dialogue[index].characterImage != null) {
            if(database.Dialogue[index].characterImagePosition != null) {
                if(database.Dialogue[index].characterImagePosition == "Left") {
                    
                } else if(database.Dialogue[index].characterImagePosition == "Right") {
                    Lihui.GetComponent<Image>().sprite = database.Dialogue[index].characterImage;
                    Lihui.transform.position = RightPosition.position;
                    Lihui.transform.localScale = new Vector3(7, 7, 1);
                    Lihui.gameObject.SetActive(true);
                }
            }
        }
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
        loadManager.instance.LoadPlaying();
    }
}
