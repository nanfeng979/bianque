using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubPuzzleManager : MonoBehaviour
{
    [SerializeField] private GameObject Puzzle;
    [SerializeField] private GameObject PuzzleQuitTips;

    public int BeClearIndex;

    public SubPuzzle[] SubPuzzles;

    public int index = 1;
    public GameObject star;

    private bool flag;

    void OnEnable() {
        flag = false;
        PuzzleQuitTips.SetActive(false);
        // 选定其中一个隐藏
        SubPuzzles[BeClearIndex].IsEnable = false;

        TestRandomPuzzle(index);
    }

    void Start()
    {
        
    }

    void Update()
    {
        PuzzleIsReset();

        if(Input.GetKeyDown(KeyCode.Space)) {
            Quit();
        }
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
            if(!flag) {
                Destroy(star);

                TuJianManager.findCaoyao("caoyao1");
                PuzzleQuitTips.SetActive(true);
                flag = true;
            }
        }
    }
    
    private void TestRandomPuzzle(int index) {
        int[] list = new int[4];

        if(index == 1) {
            list = new int[4] {7, 4, 3, 0};
        } else if(index == 2) {
            list = new int[4] {7, 6, 3, 0};
        } else if(index == 3) {
            list = new int[4] {7, 4, 1, 0};
        }


        for(int i = 0; i < list.Length; i++) {
            SubPuzzles[list[i]].Check4Dir(SubPuzzles[list[i]].Index);
        }
    }

    private void RandomPuzzle() {
        for (int i = 0; i < SubPuzzles.Length; i++) {
            int j = (int)Mathf.Floor(Random.Range(0, SubPuzzles.Length));
            SubPuzzles[i].Check4Dir(SubPuzzles[j].Index);
        }
    }

    private void RandomPuzzle(int count) {
        for (int i = 0; i < count; i++) {
            int j = (int)Mathf.Floor(Random.Range(0, SubPuzzles.Length));
            SubPuzzles[i].Check4Dir(SubPuzzles[j].Index);
        }
    }

    public void Quit() {
        Puzzle.SetActive(false);
    }
}