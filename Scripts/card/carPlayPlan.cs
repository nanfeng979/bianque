using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carPlayPlan : MonoBehaviour
{
    public static carPlayPlan instance;

    public GameObject cards;
    public cardFrame cardFrame;
    private GameObject child;

    private void Start() {
        instance = this;
    }

    private void OnEnable() {
        // 将cards加载成子对象
        child = Instantiate(cards, transform);
        child.SetActive(true);
    }

    private void OnDisable() {
        RemoveCards();
    }

    private void RemoveCards() {
        entrust.instance.destroyObject(child);
    }

    public void OnClick() {
        
        if(IsFinalGroupByCardsChild()) {
            StartCoroutine(ResetCheckChildCount());
        }
    }

    IEnumerator ResetCheckChildCount() {
        yield return new WaitForSeconds(1.0f);
        if(IsNoChildByCards()) {
            cardFrame.exitCardFrame();
        }
    }

    private bool IsFinalGroupByCardsChild() {
        return child.transform.childCount == 2;
    }

    private bool IsNoChildByCards() {
        return child.transform.childCount == 0;
    }

}
