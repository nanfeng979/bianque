using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_shifu : MonoBehaviour
{
    public GameObject tips;
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            EnableTips();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            DisableTips();
        }
    }

    private void EnableTips() {
        tips.SetActive(true);
    }

    public void DisableTips() {
        tips.SetActive(false);
    }
}
