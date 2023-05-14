using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubPuzzle : MonoBehaviour
{
    [SerializeField] private SubPuzzleManager subPuzzleManager;

    public Sprite sprite;
    public int Index;
    public int OtherIndex;
    public bool IsEnable = true;

    void Start()
    {
        
    }

    void Update()
    {
        if(IsEnable) {
            GetComponent<Image>().sprite = sprite;
        } else {
            GetComponent<Image>().sprite = null;
        }
    }

    public void OnClick() {
        Check4Dir(Index);
    }

    public void Check4Dir(int index) {
        if(index - 1 >= 0 && subPuzzleManager.SubPuzzles[index - 1].IsEnable == false) {
            ChangeAndEnable(index - 1);
        } else if(index + 1 < subPuzzleManager.SubPuzzles.Length && subPuzzleManager.SubPuzzles[index + 1].IsEnable == false) {
            ChangeAndEnable(index + 1);
        } else if(index - 3 >= 0 && subPuzzleManager.SubPuzzles[index - 3].IsEnable == false) {
            ChangeAndEnable(index - 3);
        } else if(index + 3 < subPuzzleManager.SubPuzzles.Length && subPuzzleManager.SubPuzzles[index + 3].IsEnable == false) {
            ChangeAndEnable(index + 3);
        }

    }

    private void ChangeAndEnable(int otherIndex) {
        Sprite tempSprite = sprite;
        subPuzzleManager.SubPuzzles[Index].sprite = subPuzzleManager.SubPuzzles[otherIndex].sprite;
        subPuzzleManager.SubPuzzles[otherIndex].sprite = tempSprite;
        subPuzzleManager.SubPuzzles[Index].IsEnable = false;
        subPuzzleManager.SubPuzzles[otherIndex].IsEnable = true;
    }
}
