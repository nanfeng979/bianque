using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    private List<GameObject> childList;

    void Start()
    {
        childList = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++) {
            childList.Add(transform.GetChild(i).gameObject);
        }
        Destroy(childList[0]);

        childList[1].GetComponent<RectTransform>().position -= new Vector3(210, 0);
        
        
    }

    void Update()
    {
        
    }

    // private void random() {
    //     var temp = childList[0].GetComponent<Image>().sprite;
    //     childList[0].GetComponent<Image>().sprite = childList[3].GetComponent<Image>().sprite;
    //     childList[3].GetComponent<Image>().sprite = temp;
    // }


}
