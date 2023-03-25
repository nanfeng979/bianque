using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCamera : MonoBehaviour
{
    static public faceCamera instance;
    
    // GameObject列表
    public List<GameObject> faceCamerasList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < faceCamerasList.Count; i++)
        {
            faceCamerasList[i].transform.rotation = Camera.main.transform.rotation;
        }

    }

    public void add(GameObject obj) {
        // 将对象添加到列表
        faceCamerasList.Add(obj);
    }

    public void remove(GameObject obj) {
        // 将对象从列表中移除
        faceCamerasList.Remove(obj);
    }
}
