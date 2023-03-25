using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardFrame : MonoBehaviour
{
    public GameObject yesOrNo;
    public GameObject cardPlayPlan;

    void Update()
    {
        // 按下ESC键退出
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitCardFrame();
        }
    }

    private void OnEnable() {
        // 默认关闭yesOrNo
        yesOrNo.SetActive(true);
    }

    private void OnDisable() {
        // 默认关闭所有子对象 // 必须委托给entrust
        entrust.instance.unactiveAllChild(transform);
    }

    // yes
    public void startCardPlay() {
        changeGameStatus(gameStatus.playCard);
        // 激活cardPlayPlan
        cardPlayPlan.SetActive(true);
    }

    // no
    public void exitCardFrame() {
        changeGameStatus(gameStatus.play);
        // 关闭cardFrame
        gameObject.SetActive(false);
    }

    private void changeGameStatus(gameStatus status) {
        // 将游戏状态设置为指定的状态
        GameManager.instance.SetStatus(status);
    }

}
