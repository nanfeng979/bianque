using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveBag : MonoBehaviour,IDragHandler
{
    RectTransform myBag;
    public void OnDrag(PointerEventData eventData)
    {
        if(eventData.pointerCurrentRaycast.gameObject.name == "Title_Text")
            myBag.anchoredPosition += eventData.delta;
        //anchoredPosition锚点位置
        //eventData.delta上次更新以来的指针增量
    }
    private void Awake() {
        myBag = GetComponent<RectTransform>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Escape)) {
            DisableBag();
        }
    }

    public void DisableBag() {
        gameObject.SetActive(false);
        InventoryManager.RefreshItem();
    }
}
