using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: endEvent
    /// </summary>
    public class EndEventModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "endEvent";
        private static readonly string _name = "结束";

        /// <summary>
        /// 构造方法
        /// </summary>
        public EndEventModel()
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
            this.Name = _name;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public EndEventModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 添加执行监听器
        /// </summary>
        /// <param name="executionListeners">添加执行监听器</param>
        public EndEventModel AddExecutionListeners(params ExecutionListenerModel[] executionListeners)
        {
            if (this.ExtensionElements == null)
            {
                this.ExtensionElements = new ExtensionElementsModel();
            }
            this.ExtensionElements.AddExecutionListeners(executionListeners);
            return this;
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

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
