using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskClassDataInit : MonoBehaviour
{
    public List<TaskClass> taskList = new List<TaskClass>();

    void Start()
    {
        StartCoroutine(WaitInit());
    }

    IEnumerator WaitInit() {
        yield return new WaitForSeconds(2.0f);
        AddTaskClass();
        TaskClassInsertList(taskList);
    }

    private void AddTaskClass() {
        taskList.Add(new TaskClass(1, TaskType.DiggingHerbs, "任务一", "这是任务一", "任务一ICON.png"));
        taskList.Add(new TaskClass(2, TaskType.DiggingHerbs, "任务二", "这是任务二", "任务二ICON.png"));
        taskList.Add(new TaskClass(3, TaskType.DiggingHerbs, "任务三", "这是任务三", "任务三ICON.png"));
    }

    private void TaskClassInsertList(List<TaskClass> taskList) {
        for(int i = 0; i < taskList.Count; i++) {
            TaskDataList.instance.AddTask(taskList[i]);
        }
    }
}
