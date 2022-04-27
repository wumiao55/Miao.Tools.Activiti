using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;
using System;
using System.Text;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: startEvent
    /// </summary>
    public class StartEventModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "startEvent";
        private static readonly string _name = "开始";

        /// <summary>
        /// 构造方法
        /// </summary>
        public StartEventModel()
        {
            Id = GenerateElementId();
            ElementName = _elementName;
            Name = _name;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="activitiFormKey">表单key</param>
        public StartEventModel(string activitiFormKey) : this()
        {
            ActivitiFormKey = activitiFormKey;
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
        /// 添加执行监听器
        /// </summary>
        /// <param name="executionListeners">添加执行监听器</param>
        public void AddExecutionListeners(params ExecutionListenerModel[] executionListeners)
        {
            if (ExtensionElements == null)
            {
                ExtensionElements = new ExtensionElementsModel();
            }
            ExtensionElements.AddExecutionListeners(executionListeners);
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 发起人
        /// </summary>
        [ElementProperty("activiti:initiator", false)]
        public string ActivitiInitiator { get; set; }

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
        public ExtensionElementsModel ExtensionElements { get; set; }
    }
}
