using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item",menuName ="Inventory/New Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public int itemHeld;//持有数

    [TextArea] //变成文本框
    public string itemInfo;//物品介绍

    public bool hold;//是否持有
}
