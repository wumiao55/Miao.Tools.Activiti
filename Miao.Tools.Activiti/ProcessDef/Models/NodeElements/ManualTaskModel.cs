using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// /// <summary>
    /// xml element: manualTask
    /// </summary>
    /// </summary>
    public class ManualTaskModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "manualTask";

        public ManualTaskModel()
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public ManualTaskModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 设置多实例特性
        /// </summary>
        /// <param name="multiInstanceLoopCharacteristics">多实例特性</param>
        public ManualTaskModel SetMultiInstanceLoopCharacteristics(MultiInstanceLoopCharacteristicsModel multiInstanceLoopCharacteristics)
        {
            this.MultiInstanceLoopCharacteristics = multiInstanceLoopCharacteristics;
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
        /// 多实例特性
        /// </summary>
        [ChildElement]
        public MultiInstanceLoopCharacteristicsModel MultiInstanceLoopCharacteristics { get; set; }
    }
}
