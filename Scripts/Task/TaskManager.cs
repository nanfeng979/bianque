using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public int id;
    private TMP_Text taskName;
    private TMP_Text taskDesc;
    private TMP_Text taskCondition;
    public Task task;
    bool isFinish = false;
    private void Awake() {
        taskName = transform.Find("taskName").GetComponent<TMP_Text>();
        taskDesc = transform.Find("taskDesc").GetComponent<TMP_Text>();
        taskCondition = transform.Find("taskCondition").GetComponent<TMP_Text>();
    }
    private void Update() {
        if(isFinish) {
            taskName.color = Color.green;
            taskDesc.color = Color.green;
            taskCondition.color = Color.green;
        }
        taskName.text = task.taskList[id].taskName;
        taskDesc.text = task.taskList[id].taskDesc;
        if(task.taskList[id].taskCondition.taskType == taskType.DiggingHerbs) {
            int held = task.taskList[id].taskCondition.taskItem.itemHeld;
            taskCondition.text = "(" + held.ToString() + "/" + task.taskList[id].taskCondition.taskItemHeld.ToString() + ")";
            if(held >= task.taskList[id].taskCondition.taskItemHeld) {
                isFinish = true;
            }
        }
    }
}
