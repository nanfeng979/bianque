using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuJianManager : MonoBehaviour
{
    static TuJianManager instance;
    public GameObject Grid;//存放caoyao预制体的父级
    public GameObject emptyCaoyao;//预制体
    public Inventory caoyaoList;
    public Inventory myBag;//存放的背包
    public List<GameObject> caoyaos = new List<GameObject>();
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null) { Destroy(this); }
        instance = this;
    }

    private void OnEnable()
    {
        Refreshcaoyao();//刷新背包物品格
    }

    void Update()
    {
        if (Input.GetKeyDown((KeyCode)EShortcut.Tujian) || Input.GetKeyDown(KeyCode.Escape))
        {
            DisableTujian();
        }
    }

    public void DisableTujian()
    {
        gameObject.SetActive(false);
    }

    public static void Refreshcaoyao()//刷新背包物品格
    {   //循环删除Grid下的子集物体
        for (int i = 0; i < instance.Grid.transform.childCount; i++)
        {
            if (instance.Grid.transform.childCount == 0) break;
            Destroy(instance.Grid.transform.GetChild(i).gameObject);
            instance.caoyaos.Clear();
        }
        //重新生成对应caoyaoList里面的物品的slot
        for (int i = 0; i < instance.caoyaoList.ItemList.Count; i++)
        {
            instance.caoyaos.Add(Instantiate(instance.emptyCaoyao));//实例化预制体slot类型的caoyaos列表
            instance.caoyaos[i].transform.SetParent(instance.Grid.transform);
            //将caoyaoList中的物品信息跟新到slot
            instance.caoyaos[i].GetComponent<caoyao>().SetupCaoYao(instance.caoyaoList.ItemList[i]);
        }
    }

    public static void findCaoyao(string name)
    {
        for (int i = 0; instance.caoyaoList.ItemList.Count != 0 && i < instance.caoyaoList.ItemList.Count; i++)
        {
            if (instance.caoyaoList.ItemList[i].itemName == name)
            {
                instance.caoyaoList.ItemList[i].hold = true;
                instance.AddNewcaoyao(instance.caoyaoList.ItemList[i]);
            }
        }
        Refreshcaoyao();
    }

    public void AddNewcaoyao(Item thisItem)//在背包中添加新的Item
    {
        if (!myBag.ItemList.Contains(thisItem))//如果背包中没有该Item
        {
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
        InventoryManager.RefreshItem();//刷新背包格子
    }
}
