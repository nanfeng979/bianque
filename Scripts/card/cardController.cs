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

        OnClick();
    }

    public void PlanFirstClick() {
        cardManager.instance.SetCurrentCard(this);
        AnimateToFront();
    }

    public void SameNameButIndex() {
        StartCoroutine(DestroyTwoCardByWait(animationDuration + 0.5f));
        StartCoroutine(OnClickCardPlayPlanByWait(animationDuration + 0.5f));
        ResetCurrentCard();
        AddToIllustarted(new ChineseMedicineIllustratedData(cardName, "testDes", "testSpr"));
        AnimateToFront();
    }
    public void DifferentNameAndIndex() {
        StartCoroutine(ResetTwoCardByWait(animationDuration));
        ResetCurrentCard();
        AnimateToFront();
    }

    private void AddToIllustarted(ChineseMedicineIllustratedData medicine) {
        ChineseMedicineIllustrated.instance.AddMedicine(medicine);
    }

    IEnumerator DestroyTwoCardByWait(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
        Destroy(currentCard.gameObject);
    }

    IEnumerator ResetTwoCardByWait(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        currentCard.GetComponent<Animator>().SetInteger("CardStatus", 1);
        AnimateToBack();
    }

    IEnumerator OnClickCardPlayPlanByWait(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        OnClickCardPlayPlan();
    }

    private void ResetCurrentCard() {
        cardManager.instance.init();
    }

    private void AnimateToBack() {
        animator.SetInteger("CardStatus", 1);
    }

    public void ImageToBack() {
        image.sprite = back;
    }

    private void AnimateToFront() {
        animator.SetInteger("CardStatus", 2);
    }

    public void ImageToFront() {
        image.sprite = front;
    }

    private void OnClick() {
        cardManager.instance.Click();
    }

    private void OnClickCardPlayPlan() {
        carPlayPlan.instance.OnClick();
    }

}
