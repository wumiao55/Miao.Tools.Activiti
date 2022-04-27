using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;
using System;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: userTask
    /// </summary>
    public class UserTaskModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "userTask";

        /// <summary>
        /// 构造方法
        /// </summary>
        public UserTaskModel()
        {
            Id = GenerateElementId();
            ElementName = _elementName;
            ExtensionElements = new ExtensionElementsModel() { InitiatorCanComplete = new InitiatorCanCompleteModel(false) };
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="activitiAssignee">待处理人</param>
        /// <param name="formProperties">表单属性</param>
        public UserTaskModel(string name, string activitiAssignee, params FormPropertyModel[] formProperties) : this()
        {
            Name = name;
            ActivitiAssignee = activitiAssignee;
            ExtensionElements.FormProperties = formProperties;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="activitiAssignee">待处理人</param>
        /// <param name="activitiFormKey">表单key</param>
        public UserTaskModel(string name, string activitiAssignee, string activitiFormKey) : this()
        {
            Name = name;
            ActivitiAssignee = activitiAssignee;
            ActivitiFormKey = activitiFormKey;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="activitiAssignee">待处理人</param>
        /// <param name="activitiFormKey">表单key</param>
        /// <param name="taskListeners">任务监听器</param>
        public UserTaskModel(string name, string activitiAssignee, string activitiFormKey, params TaskListenerModel[] taskListeners)
            : this(name, activitiAssignee, activitiFormKey)
        {
            ExtensionElements.TaskListeners = taskListeners;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="activitiAssignee">待处理人</param>
        /// <param name="activitiFormKey">表单key</param>
        /// <param name="multiInstanceLoopCharacteristics">多实例特性</param>
        public UserTaskModel(string name, string activitiAssignee, string activitiFormKey, MultiInstanceLoopCharacteristicsModel multiInstanceLoopCharacteristics)
            : this(name, activitiAssignee, activitiFormKey)
        {
            MultiInstanceLoopCharacteristics = multiInstanceLoopCharacteristics;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public void SetDocumentation(string documentation)
        {
            Documentation = new DocumentationModel(documentation);
        }

        /// <summary>
        /// 设置多实例特性
        /// </summary>
        /// <param name="multiInstanceLoopCharacteristics">多实例特性</param>
        public void SetMultiInstanceLoopCharacteristics(MultiInstanceLoopCharacteristicsModel multiInstanceLoopCharacteristics)
        {
            MultiInstanceLoopCharacteristics = multiInstanceLoopCharacteristics;
        }

        /// <summary>
        /// 添加表单属性
        /// </summary>
        /// <param name="formProperties">表单属性</param>
        public void AddFormProperties(params FormPropertyModel[] formProperties)
        {
            if (ExtensionElements == null)
            {
                ExtensionElements = new ExtensionElementsModel();
            }
            ExtensionElements.AddFormProperties(formProperties);
        }

        /// <summary>
        /// 添加任务监听器
        /// </summary>
        /// <param name="taskListeners">任务监听器</param>
        public void AddTaskListeners(params TaskListenerModel[] taskListeners)
        {
            if (ExtensionElements == null)
            {
                ExtensionElements = new ExtensionElementsModel();
            }
            ExtensionElements.AddTaskListeners(taskListeners);
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 待处理人
        /// </summary>
        [ElementProperty("activiti:assignee")]
        public string ActivitiAssignee { get; set; }

        /// <summary>
        /// 表单key
        /// </summary>
        [ElementProperty("activiti:formKey", false)]
        public string ActivitiFormKey { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        [ChildElement]
        public DocumentationModel Documentation { get; set; }

        /// <summary>
        /// 扩展元素
        /// </summary>
        [ChildElement]
        public ExtensionElementsModel ExtensionElements { get; protected set; }

        /// <summary>
        /// 多实例特性
        /// </summary>
        [ChildElement]
        public MultiInstanceLoopCharacteristicsModel MultiInstanceLoopCharacteristics { get; set; }
    }
}
