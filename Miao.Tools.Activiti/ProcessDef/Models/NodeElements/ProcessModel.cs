using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: process
    /// </summary>
    public class ProcessModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "process";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ProcessModel() 
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="processDefKey">流程定义key</param>
        /// <param name="name">流程定义名称</param>
        public ProcessModel(string processDefKey, string name) : this()
        {
            this.Id = processDefKey;
            this.Name = name;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档内容</param>
        public ProcessModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 添加事件监听器
        /// </summary>
        /// <param name="eventListeners">事件监听器</param>
        public ProcessModel AddEventListeners(params EventListenerModel[] eventListeners)
        {
            if(this.ExtensionElements == null)
            {
                this.ExtensionElements = new ExtensionElementsModel();
            }
            this.ExtensionElements.AddEventListeners(eventListeners);
            return this;
        }

        /// <summary>
        /// 流程定义名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否可执行(true/false)
        /// </summary>
        [ElementProperty("isExecutable")]
        public string IsExecutable { get; } = "true";

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
