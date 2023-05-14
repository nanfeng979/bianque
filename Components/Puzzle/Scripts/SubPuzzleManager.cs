using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubPuzzleManager : MonoBehaviour
{
    public int BeClearIndex;

    public SubPuzzle[] SubPuzzles;

    void OnEnable() {
        
    }

    void Start()
    {
        // 选定其中一个隐藏
        SubPuzzles[BeClearIndex].IsEnable = false;
        
        TestRandomPuzzle();
    }

    void Update()
    {
        PuzzleIsReset();
    }

    private void PuzzleIsReset() {
        int count = 0;
        for (int i = 0; i < SubPuzzles.Length; i++) {
            string spriteName = SubPuzzles[i].sprite.name;
            if((int)System.Char.GetNumericValue(spriteName[spriteName.Length - 1]) == SubPuzzles[i].Index) {
                count += 1;
            }
        }
        if(count == SubPuzzles.Length) {
            Debug.Log("yes");
        }
    }
    
    private void TestRandomPuzzle() {
        SubPuzzles[7].Check4Dir(SubPuzzles[7].Index);
    }

    private void RandomPuzzle() {
        for (int i = 0; i < SubPuzzles.Length; i++) {
            int j = (int)Mathf.Floor(Random.Range(0, SubPuzzles.Length));
            SubPuzzles[i].Check4Dir(SubPuzzles[j].Index);
        }
    }
}