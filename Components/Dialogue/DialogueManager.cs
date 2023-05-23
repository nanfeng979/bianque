using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public DialogueDatabase database;
    public TMP_Text _name;
    public TMP_Text context;

    void Start()
    {
        _name.text = database.Dialogue[0].characterName;
        context.text = database.Dialogue[0].characterDialogueContent;
    }

    void Update()
    {
        
    }
}
