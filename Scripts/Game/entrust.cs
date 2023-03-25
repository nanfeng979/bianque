using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entrust : MonoBehaviour
{
    public static entrust instance;

    public GameObject cardPlayPlan;

    void Start()
    {
        instance = this;
    }

    // 关闭指定对象的所有子对象
    public void unactiveAllChild(Transform transforms) {
        foreach (Transform child in transforms) {
            child.gameObject.SetActive(false);
        }
    }

    // 销毁指定对象
    public void destroyObject(GameObject obj) {
        Destroy(obj);
    }
    
}
