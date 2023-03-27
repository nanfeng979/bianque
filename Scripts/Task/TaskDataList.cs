using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskDataList : MonoBehaviour
{
    public static TaskDataList instance;
    public List<TaskClass> taskList = new List<TaskClass>();
    
    private void Start() {
        instance = this;
    }

    public void AddTask(TaskClass task) {
        taskList.Add(task);
    }

    public void RemoveTask(TaskClass task) {
        taskList.Remove(task);
    }

    public TaskClass GetTask(int taskId) {
        foreach (TaskClass task in taskList) {
            if (task.taskId == taskId) {
                return task;
            }
        }
        return null;
    }

}
