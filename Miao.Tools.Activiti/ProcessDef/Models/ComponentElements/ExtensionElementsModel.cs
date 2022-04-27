using Miao.Tools.Activiti.ProcessDef.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: extensionElements
    /// </summary>
    public class ExtensionElementsModel : BPMNElementModel
    {
        private static readonly string _elementName = "extensionElements";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ExtensionElementsModel()
        {
            ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="executionListeners">执行监听器</param>
        public ExtensionElementsModel(params ExecutionListenerModel[] executionListeners) : this()
        {
            ExecutionListeners = executionListeners;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="eventListeners">事件监听器</param>
        public ExtensionElementsModel(params EventListenerModel[] eventListeners) : this()
        {
            EventListeners = eventListeners;
        }

        /// <summary>
        /// 执行监听器集合
        /// </summary>
        [ChildElement]
        public IEnumerable<ExecutionListenerModel> ExecutionListeners { get; set; }

        /// <summary>
        /// 事件监听器集合
        /// </summary>
        [ChildElement]
        public IEnumerable<EventListenerModel> EventListeners { get; set; }

        /// <summary>
        /// 任务监听器集合
        /// </summary>
        [ChildElement]
        public IEnumerable<TaskListenerModel> TaskListeners { get; set; }

        /// <summary>
        /// 表单属性集合
        /// </summary>
        [ChildElement]
        public IEnumerable<FormPropertyModel> FormProperties { get; set; }

        /// <summary>
        /// 初始人是否可以完成任务
        /// </summary>
        [ChildElement]
        public InitiatorCanCompleteModel InitiatorCanComplete { get; set; }
    }
}
