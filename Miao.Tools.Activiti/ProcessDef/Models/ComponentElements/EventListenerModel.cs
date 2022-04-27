using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: activiti:eventListener
    /// </summary>
    public class EventListenerModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:eventListener";

        /// <summary>
        /// 构造方法
        /// </summary>
        public EventListenerModel()
        {
            ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="listenerType">事件类型</param>
        /// <param name="delegateExpression">委托表达式, 如: ${eventListener}</param>
        public EventListenerModel(ListenerType listenerType, string delegateExpression) : this()
        {
            Events = listenerType.ToString();
            DelegateExpression = delegateExpression;
        }

        /// <summary>
        /// 事件类型
        /// </summary>
        [ElementProperty("events")]
        public string Events { get; set; }

        /// <summary>
        /// 委托表达式, 如: ${eventListener}
        /// </summary>
        [ElementProperty("delegateExpression")]
        public string DelegateExpression { get; set; }
    }
}
