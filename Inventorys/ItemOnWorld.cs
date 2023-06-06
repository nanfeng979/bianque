using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnWorld : MonoBehaviour
{
    public Item thisItem;//该物体的Item属性
    public Inventory myBag;//存放的背包
    private bool kaiguan;//判断是否可以拾取
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            kaiguan = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            kaiguan = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown((KeyCode)EShortcut.Pickup) && kaiguan)
        {
            AddNewItem();//在背包中添加新的Item
            Destroy(gameObject);
        }
    }
    public void AddNewItem()//在背包中添加新的Item
    {
        TuJianManager.findCaoyao(thisItem.itemName);
        if (!myBag.ItemList.Contains(thisItem))//如果背包中没有该Item
        {
            thisItem.itemHeld += 1;
            for (int i = 0; i < myBag.ItemList.Count; i++)//遍历背包
            {
                if (myBag.ItemList[i] == null)//该背包格子为空则放到该位置
                {
                    myBag.ItemList[i] = thisItem;
                    break;
                }
            }
        }
        else
        {
            thisItem.itemHeld += 1;//如果背包中有该Item,则数量+1
        }
    }
}
