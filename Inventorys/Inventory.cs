using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Inventory",menuName ="Inventory/New Inventory")]
public class Inventory : ScriptableObject
{
    //创建Item类列表
    public List<Item> ItemList = new List<Item>();
}
