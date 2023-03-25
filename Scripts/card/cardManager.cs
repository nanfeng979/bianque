using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardManager : MonoBehaviour
{
    public static cardManager instance;

    private bool canClicked = true;
    // 时长跟Card动画时间相关
    // private const float animationDuration = 1.0f;
    private float nextClickTimer = 1.0f;
    private float sinceClickTime = 0.0f;
    private cardController currentCard;


    void Start()
    {
        instance = this;
    }
    
    private void Update() {
        if(!CanClicked()) {
            sinceClickTime += Time.deltaTime;
            if(sinceClickTime > nextClickTimer) {
                canClicked = true;
                sinceClickTime = 0.0f;
            }
        }
    }

    // 初始化
    public void init() {
        ResetCurrentCard();
    }

    // Clicked
    public void Click() {
        canClicked = false;
    }
    public bool CanClicked() {
        return canClicked;
    }

    // CurrentCard
    public void SetCurrentCard(cardController obj)
    {
        currentCard = obj;
    }

    public cardController GetCurrentCard()
    {
        return currentCard;
    }

    public void ResetCurrentCard()
    {
        currentCard = null;
    }

    public bool CurrentCardIsNull() {
        return currentCard == null;
    }

    
}
