using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caoyao : MonoBehaviour
{
    public string caoyaoName;
    public Image caoyaoImage;
    public string caoyaoInfo;//草药介绍
    public bool caoyaohold;//是否持有
    [Range(0f, 1f)]
    public float transparencyValue = 0.5f;
    Color tempColor;
    private void Awake() {
        tempColor = caoyaoImage.color;
        tempColor.a = transparencyValue;
    }
    //将tujian中的物品信息跟新到caoyao
    public void SetupCaoYao(Item item)
    {
        caoyaoName = item.itemName;
        caoyaoImage.sprite = item.itemImage;
        caoyaoInfo = item.itemInfo;
        caoyaohold = item.hold;
        
        if(caoyaohold) {tempColor.a = 1f;}

        caoyaoImage.color = tempColor; 
    }
    
}
