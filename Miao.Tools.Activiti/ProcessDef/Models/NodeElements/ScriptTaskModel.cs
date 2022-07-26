using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    /// <summary>
    /// xml element: scriptTask
    /// </summary>
    public class ScriptTaskModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "scriptTask";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ScriptTaskModel()
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
        }

        /// <summary>
        /// 设置文档
        /// </summary>
        /// <param name="documentation">文档</param>
        public ScriptTaskModel SetDocumentation(string documentation)
        {
            this.Documentation = new DocumentationModel(documentation);
            return this;
        }

        /// <summary>
        /// 设置脚本
        /// </summary>
        /// <param name="script">脚本内容</param>
        /// <returns></returns>
        public ScriptTaskModel SetScript(string script)
        {
            this.Script = new ScriptModel(script);
            return this;
        }

        /// <summary>
        /// 设置多实例特性
        /// </summary>
        /// <param name="multiInstanceLoopCharacteristics">多实例特性</param>
        public ScriptTaskModel SetMultiInstanceLoopCharacteristics(MultiInstanceLoopCharacteristicsModel multiInstanceLoopCharacteristics)
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
        /// 脚本格式,如: groovy
        /// </summary>
        [ElementProperty("scriptFormat")]
        public string ScriptFormat { get; set; }

        /// <summary>
        /// 是否自动存储变量
        /// </summary>
        [ElementProperty("activiti:autoStoreVariables")]
        public string AutoStoreVariables { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        [ChildElement]
        public DocumentationModel Documentation { get; set; }

        /// <summary>
        /// 脚本
        /// </summary>
        [ChildElement]
        public ScriptModel Script { get; set; }

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
