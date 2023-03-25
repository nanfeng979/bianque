using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public Sprite spr;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSprite() {
        GetComponent<Image>().sprite = spr;
        Debug.Log("test");
    }

    public void myTest() {
        Debug.Log("test");
    }
}
