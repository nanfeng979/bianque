public enum TaskType {
    None,
    DiggingHerbs,
    GrowingHerbs
}
public class TaskClass
{
    public int taskId;
    public TaskType taskType;
    public string taskName;
    public string taskDesc;
    public string taskIcon;

    public TaskClass()
    {
        this.taskId = 0;
        this.taskType = TaskType.None;
        this.taskName = "";
        this.taskDesc = "";
        this.taskIcon = "";
    }

    public TaskClass(int taskId, TaskType taskType, string taskName, string taskDesc, string taskIcon)
    {
        this.taskId = taskId;
        this.taskType = taskType;
        this.taskName = taskName;
        this.taskDesc = taskDesc;
        this.taskIcon = taskIcon;
    }

}
