using UnityEngine;

[System.Serializable]
public struct DialogueStruct {
    public string characterName;
    public string characterDialogueContent;
    public Sprite characterImage;
    public string characterImagePosition;
}

[CreateAssetMenu(fileName = "NewDialogueDatabase", menuName = "Dialogue System/Dialogue Database")]
public class DialogueDatabase : ScriptableObject
{
    [SerializeField] private DialogueStruct[] dialogue;

    public DialogueStruct[] Dialogue => dialogue;

}
