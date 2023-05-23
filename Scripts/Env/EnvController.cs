using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvController : MonoBehaviour
{
    private int childCount;
    private Transform[] childs;

    void Start()
    {
        childCount = transform.childCount;
        childs = new Transform[childCount];
        
        for(int i = 0; i < childCount; i++)
        {
            childs[i] = transform.GetChild(i);
        }
    }

    void Update()
    {
        for(int i = 0; i < childCount; i++)
        {
            childs[i].rotation = Camera.main.transform.rotation;
        }
    }
}
