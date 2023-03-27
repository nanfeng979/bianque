using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) {
            TaskDataListTest();
        }
    }

    private void ChineseMedicineIllustratedTest() {
        List<ChineseMedicineIllustratedData> medicines = ChineseMedicineIllustrated.instance.medicinesList;
        for(int i = 0; i < medicines.Count; i++) {
            Debug.Log(medicines[i].Name + "_" + medicines[i].Description + "_" + medicines[i].Sprite);
        }
    }

    private void TaskDataListTest() {
        List<TaskClass> taskList = TaskDataList.instance.taskList;
        for(int i = 0; i < taskList.Count; i++) {
            Debug.Log(taskList[i].taskId + "_" + taskList[i].taskType + "_" + taskList[i].taskName + "_" + taskList[i].taskDesc + "_" + taskList[i].taskIcon);
        }
    }

    public void myTest() {
        Debug.Log("test");
    }
}
