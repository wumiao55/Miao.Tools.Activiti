using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: serviceTask, type:camel
    /// </summary>
    public class CamelTaskModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "serviceTask";
        private static readonly string _type = "camel";

        /// <summary>
        /// 构造方法
        /// </summary>
        public CamelTaskModel()
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
            this.Type = _type;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public CamelTaskModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 设置多实例特性
        /// </summary>
        /// <param name="multiInstanceLoopCharacteristics">多实例特性</param>
        public CamelTaskModel SetMultiInstanceLoopCharacteristics(MultiInstanceLoopCharacteristicsModel multiInstanceLoopCharacteristics)
        {
            this.MultiInstanceLoopCharacteristics = multiInstanceLoopCharacteristics;
            return this;
        }

        /// <summary>
        /// 添加字段
        /// </summary>
        /// <param name="activitiFields"></param>
        /// <returns></returns>
        public CamelTaskModel AddActivitiFields(params ActivitiFieldModel[] activitiFields)
        {
            if (this.ExtensionElements == null)
            {
                this.ExtensionElements = new ExtensionElementsModel();
            }
            this.ExtensionElements.AddActivitiFields(activitiFields);
            return this;
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [ElementProperty("activiti:type")]
        public string Type { get; private set; }

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

        /// <summary>
        /// 多实例特性
        /// </summary>
        [ChildElement]
        public MultiInstanceLoopCharacteristicsModel MultiInstanceLoopCharacteristics { get; set; }
    }
}
