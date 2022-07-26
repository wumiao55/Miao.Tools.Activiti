using Miao.Tools.Activiti.ProcessDef.Attributes;

namespace Miao.Tools.Activiti.ProcessDef.Models.ComponentElements
{
    /// <summary>
    /// xml element: conditionExpression
    /// </summary>
    public class ConditionExpressionModel : BPMNElementModel
    {
        private static readonly string _elementName = "conditionExpression";
        private static readonly string _defaultType = "tFormalExpression";

        /// <summary>
        /// 构造方法
        /// </summary>
        public ConditionExpressionModel()
        {
            this.ElementName = _elementName;
            this.CData = true;
            this.Type = _defaultType;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="conditionExpression">表达式内容</param>
        public ConditionExpressionModel(string conditionExpression) : this()
        {
            this.InnerText = conditionExpression;
        }

        /// <summary>
        /// 表达式类型
        /// </summary>
        [ElementProperty("xsi:type")]
        public string Type { get; set; }
    }
}
