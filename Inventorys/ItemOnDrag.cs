using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemOnDrag : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Transform oldParent;//原始父级
    public Inventory myBag;
    private int currentItemID;//当前ID
    public void OnBeginDrag(PointerEventData eventData)
    {
        oldParent = transform.parent;//即为slot(Clone)
        currentItemID = oldParent.GetComponent<Slot>().slotID;
        transform.SetParent(transform.parent.parent);//即放到Grid_Image下
        transform.position = eventData.position;
        //关闭射线，blocksRaycasts它控制了这个UI元素是否能够接收鼠标或触摸屏的输入事件
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //判断当前鼠标射线是否有物体即有图片item image，交换两个格子中的物体
        if (eventData.pointerCurrentRaycast.gameObject.name == "Image")
        {
            transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform.parent.parent);
            transform.position = eventData.pointerCurrentRaycast.gameObject.transform.parent.parent.position;

            var temp = myBag.ItemList[currentItemID];
            myBag.ItemList[currentItemID] = myBag.ItemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID];
            myBag.ItemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID] = temp;

            eventData.pointerCurrentRaycast.gameObject.transform.parent.SetParent(oldParent);
            eventData.pointerCurrentRaycast.gameObject.transform.parent.position = oldParent.position;

            GetComponent<CanvasGroup>().blocksRaycasts = true;//射线阻挡开启，不然无法再次选中移动的物品
            return;
        }
        if(eventData.pointerCurrentRaycast.gameObject.name == "slot(Clone)")
        {
            //格子为空时交换
            transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform);
            transform.position = eventData.pointerCurrentRaycast.gameObject.transform.position;

            myBag.ItemList[eventData.pointerPressRaycast.gameObject.GetComponentInParent<Slot>().slotID] = myBag.ItemList[currentItemID];
            //解决自己放自己位置的问题
            if(eventData.pointerPressRaycast.gameObject.GetComponentInParent<Slot>().slotID != currentItemID)
                myBag.ItemList[currentItemID] = null;

            GetComponent<CanvasGroup>().blocksRaycasts = true;
            return;
        }
        //其他任何位置都归位物品
        transform.SetParent(oldParent);
        transform.position = oldParent.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
