using Miao.Tools.Activiti.ProcessDef.Attributes;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    ///  xml element: activiti:field
    /// </summary>
    public class ActivitiFieldModel : BPMNElementModel
    {
        private static readonly string _elementName = "activiti:field";

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        public ActivitiFieldModel(string name, string value)
        {
            this.ElementName = _elementName;
            this.Name = name;
            this.StringModel = new ActivitiStringModel(value);
        }

        /// <summary>
        /// 名称
        /// </summary>
        [ElementProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 字符串模型
        /// </summary>
        [ChildElement]
        public ActivitiStringModel StringModel { get; set; }
    }
}
