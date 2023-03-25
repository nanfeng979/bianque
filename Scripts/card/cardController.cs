using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardController : MonoBehaviour
{
    // self data
    public int cardIndex;
    public string cardName;
    public Sprite front;
    public Sprite back;

    private cardController currentCard;

    private Image image;
    private Animator animator;

    // 时长跟Card动画时长相关
    private const float animationDuration = 1.0f;

    private float AnimateToBackTimer = 1.0f;
    private float AnimateToBackTime = 0.0f;
    private float AnimateToFrontTimer = 1.0f;
    private float AnimateToFrontTime = 1.0f;


    void Start()
    {
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();
    }

    public void beClick() {
        if(!cardManager.instance.CanClicked()) {
            return;
        }

        if(cardManager.instance.CurrentCardIsNull()) {
            PlanFirstClick();
        } else {
            currentCard = cardManager.instance.GetCurrentCard();
            if(this == currentCard) {
            } else if(currentCard.cardIndex != cardIndex && currentCard.cardName == cardName) {
                SameNameButIndex();
            } else {
                DifferentNameAndIndex();
            }
        }

        cardManager.instance.Click();
    }

    public void PlanFirstClick() {
        cardManager.instance.SetCurrentCard(this);
        AnimateToFront();
    }

    public void SameNameButIndex() {
        StartCoroutine(DestroyTwoCardByWait(animationDuration + 0.5f));
        ResetCurrentCard();
        AnimateToFront();
    }
    public void DifferentNameAndIndex() {
        AnimateToFront();
        StartCoroutine(ResetTwoCardByWait(animationDuration));
        ResetCurrentCard();
    }

    IEnumerator DestroyTwoCardByWait(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
        Destroy(currentCard.gameObject);
    }

    IEnumerator ResetTwoCardByWait(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        AnimateToBack();
        currentCard.GetComponent<Animator>().SetInteger("CardStatus", 1);
    }

    private void ResetCurrentCard() {
        cardManager.instance.init();
    }

    private void AnimateToBack() {
        animator.SetInteger("CardStatus", 1);
    }

    public void ImageToBack() {
        image.sprite = back;
        Debug.Log("ImageToBack");
    }

    private void AnimateToFront() {
        animator.SetInteger("CardStatus", 2);
    }

    public void ImageToFront() {
        image.sprite = front;
        Debug.Log("ImageToFront");
    }

}
