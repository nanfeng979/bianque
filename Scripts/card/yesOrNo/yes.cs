using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    public GameObject yesOrNo;
    public GameObject cardPlayPlan;
    public Transform player;
    

    public GameObject cards;


    private void OnMouseDown() {
        // 进入子游戏
        enter();
    }

    private void enter() {
        // 将游戏状态设置为playCard
        GameManager.instance.SetStatus(gameStatus.playCard);

        // 将子游戏页面设置为可见
        cardPlayPlan.gameObject.SetActive(true);
        // 更新子游戏页面位置
        cardPlayPlan.gameObject.transform.position = player.transform.position;
        // 在子游戏页面上添加cards
        GameObject cardsClone = Instantiate(cards, cardPlayPlan.transform.position, Quaternion.identity, cardPlayPlan.transform);
        // 调整大小
        cardsClone.transform.localScale = new Vector3(0.21f, 0.38f, 1.0f);
        // 设置cardsClone可见
        cardsClone.SetActive(true);
        // 添加到faceCamera列表里
        faceCamera.instance.add(cardsClone);

        // 最后隐藏yesOrNo
        yesOrNo.SetActive(false);
    
    }

}
