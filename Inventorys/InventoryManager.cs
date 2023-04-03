using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;
    public GameObject slotGrid;//存放slot的父级
    public GameObject emptySlot;//空格子slot
    public Inventory myBag;
    public Text itemInfo;//物品描述

    public List<GameObject> slots = new List<GameObject>();
    void Awake()
    {
        if (instance != null) { Destroy(this); }
        instance = this;
    }
    private void OnEnable() {
        RefreshItem();//刷新背包物品格
        instance.itemInfo.text = "";
    }
    public static void UpdateItemInfo(string itemDescription)
    {
        instance.itemInfo.text = itemDescription;
    }
    public static void RefreshItem()//刷新背包物品格
    {   //循环删除slotGrid下的子集物体
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if(instance.slotGrid.transform.childCount == 0) break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
            instance.slots.Clear();
        }
        //重新生成对应myBag里面的物品的slot
        for (int i = 0; i < instance.myBag.ItemList.Count; i++)
        {
             instance.slots.Add(Instantiate(instance.emptySlot));//实例化预制体slot类型的slots列表
             instance.slots[i].transform.SetParent(instance.slotGrid.transform);
             //将myBag中的物品信息跟新到slot
             instance.slots[i].GetComponent<Slot>().SetupSlot(instance.myBag.ItemList[i]);
             instance.slots[i].GetComponent<Slot>().slotID = i;
        }
    }
}
