using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCamera : MonoBehaviour
{
    static public faceCamera instance;
    
    // GameObject列表
    public List<GameObject> faceCamerasList = new List<GameObject>();
    public List<GameObject> faceCamerasListHaveChilds = new List<GameObject>();

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        SetCameraByFaceCamerasList();
        SetCameraByFaceCamerasListHaveChilds();

    }

    private void SetCameraByFaceCamerasList() {
        for(int i = 0; i < faceCamerasList.Count; i++) {
            faceCamerasList[i].transform.rotation = Camera.main.transform.rotation;
        }
    }

    private void SetCameraByFaceCamerasListHaveChilds() {
        for(int i = 0; i < faceCamerasListHaveChilds.Count; i++) {
            for(int j = 0; j < faceCamerasListHaveChilds[i].transform.childCount; j++) {
                faceCamerasListHaveChilds[i].transform.GetChild(j).rotation = Camera.main.transform.rotation;
            }
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
