using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager instance;

    // 写一份二维数组，存储已经收集到的所有的牌名，第一维只有4个，分别为赋值为春夏秋冬，第二位长度不固定
    public string[][] cardName = new string[4][];

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        // 初始化二维数组
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
