using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.ProcessDef.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: activiti:taskListener
    /// </summary>
    public class TaskListenerModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:taskListener";

        /// <summary>
        /// 构造方法
        /// </summary>
        public TaskListenerModel()
        {
            ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="eventType">事件类型</param>
        /// <param name="delegateExpression">委托表达式, 如: ${taskListener}</param>
        public TaskListenerModel(TaskListenerEventType eventType, string delegateExpression) : this()
        {
            Event = eventType.GetDescription();
            DelegateExpression = delegateExpression;
        }

        /// <summary>
        /// 事件(create/assignment/complete/delete)
        /// </summary>
        [ElementProperty("event")]
        public string Event { get; set; } = "complete";

        /// <summary>
        /// 委托表达式, 如: ${taskListener}
        /// </summary>
        [ElementProperty("delegateExpression")]
        public string DelegateExpression { get; set; } = "${taskListener}";
    }
}
