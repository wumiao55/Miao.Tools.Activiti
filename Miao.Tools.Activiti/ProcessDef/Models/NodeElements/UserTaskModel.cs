using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

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
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
            this.ExtensionElements = new ExtensionElementsModel() { InitiatorCanComplete = new InitiatorCanCompleteModel(false) };
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="activitiAssignee">待处理人</param>
        /// <param name="formProperties">表单属性</param>
        public UserTaskModel(string name, string activitiAssignee, params FormPropertyModel[] formProperties) : this()
        {
            this.Name = name;
            this.ActivitiAssignee = activitiAssignee;
            this.ExtensionElements.FormProperties = formProperties;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="activitiAssignee">待处理人</param>
        /// <param name="activitiFormKey">表单key</param>
        public UserTaskModel(string name, string activitiAssignee, string activitiFormKey) : this() 
        {
            this.Name = name;
            this.ActivitiAssignee = activitiAssignee;
            this.ActivitiFormKey = activitiFormKey;
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
            this.ExtensionElements.TaskListeners = taskListeners;
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
            this.MultiInstanceLoopCharacteristics = multiInstanceLoopCharacteristics;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public UserTaskModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 设置多实例特性
        /// </summary>
        /// <param name="multiInstanceLoopCharacteristics">多实例特性</param>
        public UserTaskModel SetMultiInstanceLoopCharacteristics(MultiInstanceLoopCharacteristicsModel multiInstanceLoopCharacteristics)
        {
            this.MultiInstanceLoopCharacteristics = multiInstanceLoopCharacteristics;
            return this;
        }

        /// <summary>
        /// 添加表单属性
        /// </summary>
        /// <param name="formProperties">表单属性</param>
        public UserTaskModel AddFormProperties(params FormPropertyModel[] formProperties)
        {
            if (this.ExtensionElements == null)
            {
                this.ExtensionElements = new ExtensionElementsModel();
            }
            this.ExtensionElements.AddFormProperties(formProperties);
            return this;
        }

        /// <summary>
        /// 添加任务监听器
        /// </summary>
        /// <param name="taskListeners">任务监听器</param>
        public UserTaskModel AddTaskListeners(params TaskListenerModel[] taskListeners)
        {
            if(this.ExtensionElements == null)
            {
                this.ExtensionElements = new ExtensionElementsModel();
            }
            this.ExtensionElements.AddTaskListeners(taskListeners);
            return this;
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
