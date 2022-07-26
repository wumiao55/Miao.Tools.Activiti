using Miao.Tools.Activiti.ProcessDef.Attributes;
using Miao.Tools.Activiti.ProcessDef.Extensions;
using Miao.Tools.Activiti.ProcessDef.Models.ComponentElements;

namespace Miao.Tools.Activiti.ProcessDef.Models.NodeElements
{
    public class ShellTaskModel : BPMNNodeElementModel
    {
        private static readonly string _elementName = "serviceTask";
        private static readonly string _type = "shell";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ShellTaskModel()
        {
            this.Id = GenerateElementId();
            this.ElementName = _elementName;
            this.Type = _type;
        }

        /// <summary>
        /// 添加字段
        /// </summary>
        /// <param name="activitiFields"></param>
        /// <returns></returns>
        public ShellTaskModel AddActivitiFields(params ActivitiFieldModel[] activitiFields)
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
        /// 扩展元素
        /// </summary>
        [ChildElement]
        public ExtensionElementsModel ExtensionElements { get; set; }
    }
}
