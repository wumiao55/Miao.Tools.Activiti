using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.Extensions;
using Miao.Tools.Activiti.ProcessDef.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: activiti:executionListener
    /// </summary>
    public class ExecutionListenerModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:executionListener";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ExecutionListenerModel()
        {
            ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="eventType">事件类型</param>
        /// <param name="delegateExpression">委托表达式, 如: ${commonExecutionListener}</param>
        public ExecutionListenerModel(ExecutionListenerEventType eventType, string delegateExpression) : this()
        {
            Event = eventType.GetDescription();
            DelegateExpression = delegateExpression;
        }

        /// <summary>
        /// 事件(start/end/take)
        /// </summary>
        [ElementProperty("event")]
        public string Event { get; set; } = "end";

        /// <summary>
        /// 委托表达式, 如: ${commonExecutionListener}
        /// </summary>
        [ElementProperty("delegateExpression")]
        public string DelegateExpression { get; set; } = "${commonExecutionListener}";
    }
}
