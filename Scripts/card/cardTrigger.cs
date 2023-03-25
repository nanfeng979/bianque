using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject cardFrame;
    
    private void OnTriggerEnter2D(Collider2D other) {
        // 如果经过的对象layer是Player
        if (other.gameObject == player) {
            PlayerCollider();
        }
    }

    private void PlayerCollider() {
        // 将cardFrame设置为可见
        cardFrame.SetActive(true);
        // 将游戏状态设置成playCard
        GameManager.instance.SetStatus(gameStatus.playCard);
    }

}
