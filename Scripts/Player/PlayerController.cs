using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;

    public GameObject MyBag;

    private float inputX;
    private float inputY;
    private Vector2 direction;
    private Animator anim;
    private Rigidbody2D rig;

    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 如果游戏状态不为play，则不执行
        if (GameManager.instance.GetStatus() != gameStatus.play) {
            rig.velocity = Vector2.zero;
            return;
        }
        
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        // 乘以transform.right是为了在人物旋转后依旧使用自己的坐标系的右方向
        direction = (transform.right * inputX + transform.up * inputY).normalized;
        rig.velocity = direction.normalized * speed;

        if(direction != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
        } else {
            anim.SetBool("isWalking", false);
        }

        anim.SetFloat("InputX", inputX);
        anim.SetFloat("InputY", inputY);

        if(Input.GetKeyDown(KeyCode.B))
        {   
            if(!MyBag.activeSelf) {
                EnableBag();
            }
        }
    }

    private void EnableBag() {
        MyBag.SetActive(true);
        InventoryManager.RefreshItem();
    }
    
}
