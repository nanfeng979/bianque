using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum taskType {
    None,
    DiggingHerbs,
    GrowingHerbs
}
[System.Serializable]
public struct TaskCondition {
    public taskType taskType;
    public Item taskItem;
    public int taskItemHeld;

}
[System.Serializable]
public struct taskData { 
    [Header("任务ID")]
    public int taskId;
    [Header("任务名称")]
    public string taskName;
    [Header("任务描述")]
    public string taskDesc;
    [Header("任务条件")]
    public TaskCondition taskCondition;
}
[CreateAssetMenu(fileName = "NewTask", menuName = "NewTask/Task")]
public class Task : ScriptableObject
{
    public List<taskData> taskList;
}
