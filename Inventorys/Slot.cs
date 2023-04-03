using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
    //public Item slotItem;
    public Image slotImage;
    public Text slotNum;
    public string slotInfo;//物品介绍
    public int slotID;
    public GameObject itemInSlot;//slot中的item
    //组件上点击物品格时触发
    public void ItemOnClicked()//组件上点击物品格时触发
    {
        InventoryManager.UpdateItemInfo(slotInfo);//更新物品描述
    }

    //将myBag中的物品信息跟新到slot
    public void SetupSlot(Item item)
    {
        if(item == null)
        {
            itemInSlot.SetActive(false);//设置item不可见
            return;
        }
        slotImage.sprite = item.itemImage;
        slotNum.text = item.itemHeld.ToString();
        slotInfo = item.itemInfo;
    }
}
