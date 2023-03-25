using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carPlayPlan : MonoBehaviour
{
    public GameObject cards;
    private GameObject child;

    private void OnEnable() {
        // 将cards加载成子对象
        child = Instantiate(cards, transform);
        child.SetActive(true);
    }

    private void OnDisable() {
        // 移除cards
        entrust.instance.destroyObject(child);
    }

}
