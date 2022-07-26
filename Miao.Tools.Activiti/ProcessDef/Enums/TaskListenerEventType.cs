using System.ComponentModel;

namespace Miao.Tools.Activiti.ProcessDef.Enums
{
    /// <summary>
    /// 任务监听事件类型
    /// </summary>
    public enum TaskListenerEventType
    {
        /// <summary>
        /// create
        /// </summary>
        [Description("create")]
        Create = 0,

        /// <summary>
        /// assignment
        /// </summary>
        [Description("assignment")]
        Assignment = 1,

        /// <summary>
        /// complete
        /// </summary>
        [Description("complete")]
        Complete = 2,

        /// <summary>
        /// delete
        /// </summary>
        [Description("delete")]
        Delete = 3
    }
}
